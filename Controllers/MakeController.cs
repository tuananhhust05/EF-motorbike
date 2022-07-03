using Microsoft.AspNetCore.Mvc;
using System.Linq;
using vroom2.AppDbContext;
using vroom2.Models;

namespace vroom2.Controllers
{
    public class MakeController : Controller
    {
        private readonly VroomDbContext _db;


        // contructor 
        public MakeController(VroomDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.Makes.ToList());  // trả về view bảng Makes  ; lấy toàn bộ data lên 
        }


        // Create 
        [HttpGet]

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(string  Name,string id)  //truyền vào 1 đối tượng make
        {
            Make make = new Make();
            make.Name = Name;
          
          
            if (ModelState.IsValid)   // điều kiện để duyệt 
            {
                _db.Add(make);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index)); // truyền đến trang index để chạy nó và hiển thị thằng vừa thêm 
            }
            return View(make); 
        }





        [HttpPost]
        public IActionResult Delete(string  Id)  // id lấy từ form index 
        {
            
            var a = _db.Makes.Find(int.Parse(Id));
            // chỉ tìm được theo khóa chính 
            //var make = _db.Makes.Find(int.Parse(Id.ToString()));  // tìm đối tượng 
            if (a == null)
            {
                return NotFound();
            }
            _db.Makes.Remove(a); // tất cả đối tương liên quan tới make 
            _db.SaveChanges();
            return RedirectToAction(nameof(Index)); // xóa xong trở lại trang cũ 
        }




       
        public IActionResult Edit()
        {
            var reqUrl = Request.HttpContext.Request;
            var urlPath = reqUrl.Path;
            var Id = urlPath.ToString().Split('/').Last();

            // chỉ tìm được theo khóa chính 
            var make = _db.Makes.Find(int.Parse(Id.ToString()));  // tìm đối tượng 
            if (make == null)
            {
                return NotFound();
            }
      
            return View(make); // xóa xong trở lại trang cũ 
        }


        // update 
     
      
        [HttpPost]

        // bắt buộc phải truyền như vậy để khi cập nhật thì cập nhật đích xác thằng make đó; không tạo mới 
        public IActionResult Edit(Make make)  //truyền vào 1 đối tượng Make
        {

           

            if (ModelState.IsValid)   // điều kiện để duyệt 
            {
                _db.Update(make);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index)); // truyền đến trang index để chạy nó và hiển thị thằng vừa thêm 
            }
            return View(make);
        }

    }
}
