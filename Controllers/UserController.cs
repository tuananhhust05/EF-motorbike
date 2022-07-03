using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Linq;
using vroom2.AppDbContext;
using vroom2.Models;

namespace vroom2.Controllers
{
    public class UserController : Controller
    {
        private readonly VroomDbContext _db;

        [BindProperty]
        public ModelViewModel ModelVM { get; set; }
        // contructor 
        public UserController(VroomDbContext db)
        {
            _db = db;
            ModelVM = new ModelViewModel()
            {
                Makes = _db.Makes.ToList(), // lấy dữ liệu từ bảng bảng Make 
                Model = new Models.Model()
            };
        }

        public IActionResult Index()
        {
            // lấy thông tin đăng nhập 
            var tkdangnhap = JsonConvert.DeserializeObject<TkDangNhap>(HttpContext.Session.GetString("DangNhapSession"));

            ViewBag.Name = "Xin chào " + tkdangnhap.Ten;
            // truyền vào 1 danh sách Model ( gồm cả thằng Make ở trong) 
            var model = _db.Models.Include(m => m.Make);// 1 danh sách models 
            return View(model);
        }



        [HttpPost]
        public IActionResult DatHang(string Ten, string SDT,string Date,string IdModel)
        {
            DonHang donhang = new DonHang();
            // lấy thông tin hàng hóa 
            var thongtinhang = _db.Models.Find(int.Parse(IdModel.ToString()));
            // lấy iduser từ session 
            var tkdangnhap = JsonConvert.DeserializeObject<TkDangNhap>(HttpContext.Session.GetString("DangNhapSession"));

            // Thông tin khách hàng  
            donhang.IDUser = tkdangnhap.Id.ToString();

            // thông tin hàng hóa 
            donhang.IDModels = IdModel;// lấy id model từ form 
            donhang.Name = thongtinhang.Name;
            donhang.ImageUrl = thongtinhang.ImageUrl;
            donhang.Price = thongtinhang.Price;

            // thông tin đặt hàng 
            donhang.HoTen = Ten;
            donhang.SDT = SDT;
            donhang.NgayXemXe = Date;

            // tình trang đơn hàng;
            donhang.TinhTrang = "Chưa giao xe";

            _db.Add(donhang);
            _db.SaveChanges();
            return RedirectToAction(nameof(GioHang));
           
        }


        public IActionResult GioHang()
        {
            var tkdangnhap = JsonConvert.DeserializeObject<TkDangNhap>(HttpContext.Session.GetString("DangNhapSession"));
            
            return View(_db.DonHangs.Where(p => p.IDUser== tkdangnhap.Id.ToString()).ToList());
        }





        //[HttpGet]  không dùng get 
        public IActionResult EditDonHang()
        {
            var reqUrl = Request.HttpContext.Request;
            var urlPath = reqUrl.Path;
            var Id = urlPath.ToString().Split('/').Last();

            // chỉ tìm được theo khóa chính 
            var donhang = _db.DonHangs.Find(int.Parse(Id));  // tìm đối tượng 
            if (donhang == null)
            {
                return NotFound();
            }

            return View(donhang); // xóa xong trở lại trang cũ 
        }
        [HttpPost]
        public IActionResult EditDonHang(DonHang donhang)  //truyền vào 1 đối tượng Make
        {



            if (ModelState.IsValid)   // điều kiện để duyệt xem lượng ký tự có dài quá không 
            {
                _db.Update(donhang);
                _db.SaveChanges();
                return RedirectToAction(nameof(GioHang)); // truyền đến trang index để chạy nó và hiển thị thằng vừa thêm 
            }
            return View(donhang);  // tiếp tục chỉnh sửa 
        }



       

    }
}
