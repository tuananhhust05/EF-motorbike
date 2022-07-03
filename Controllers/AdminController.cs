using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using vroom2.AppDbContext;
using vroom2.Models;

namespace vroom2.Controllers
{
    public class AdminController : Controller
    {
        private readonly VroomDbContext _db;

        public AdminController(VroomDbContext db)
        {
            _db = db;
        }
        public IActionResult DsDonHang()
        {

            List<DonHang> dsdonhang = new List<DonHang>();

            // chia đôi ra 
            var dsdonhang1 = _db.DonHangs.Where(p => p.TinhTrang == "Đã Giao").ToList();
            var dsdonhang2 = _db.DonHangs.Where(p => p.TinhTrang == "Chưa giao xe").ToList();
            foreach(var item in dsdonhang1)
            {
                dsdonhang.Add(item);
            }
            foreach(var utem in dsdonhang2)
            {
                dsdonhang.Add(utem);
            }
            return View(dsdonhang);

        }



        public IActionResult HoanThanhDonHang()
        {
            // lấy id 
            var reqUrl = Request.HttpContext.Request;
            var urlPath = reqUrl.Path;
            var id = urlPath.ToString().Split('/').Last();

            // lấy thằng cần update lên 
            var a = _db.DonHangs.Find(int.Parse(id));
            a.TinhTrang = "Đã Giao";

            _db.Update(a);
            _db.SaveChanges();
            return RedirectToAction(nameof(DsDonHang));
            
        }




        [HttpPost]
        public IActionResult DeleteDonHang(string Id)  // id lấy từ form index 
        {

            var a = _db.DonHangs.Find(int.Parse(Id));
            // chỉ tìm được theo khóa chính 
            //var make = _db.Makes.Find(int.Parse(Id.ToString()));  // tìm đối tượng 
            if (a == null)
            {
                return NotFound();
            }
            _db.DonHangs.Remove(a); // tất cả đối tương liên quan tới make 
            _db.SaveChanges();
            return RedirectToAction(nameof(DsDonHang)); // xóa xong trở lại trang cũ 
        }



        public IActionResult DanhSachTk()
        {

            // lấy danh sách Id 
            var dsid = _db.TkDangNhaps.ToList();

            List<DoanhSoId> result = new List<DoanhSoId>();
            foreach(var item in dsid)
            {
                DoanhSoId a = new DoanhSoId();
                int tongtien = 0;
                // lấy tất cả đơn hàng có id này 
                var dsdonhang = _db.DonHangs.Where(p => p.IDUser == item.Id.ToString()).ToList();
                // tính tổng tiền 
                foreach(var item1 in dsdonhang)
                {
                    tongtien = tongtien + int.Parse(item1.Price);
                }
                a.Id = item.Id;
                a.DoanhSo = tongtien;
                a.Ten = item.Ten;
                
                result.Add(a);
            }


            DoanhSoId tempt = new DoanhSoId();
            // sắp xếp theo tổng 
            for (int i = 0; i < result.Count; i++)
            {
                for(int j = i + 1; j < result.Count; j++)
                {
                    if (result[j].DoanhSo > result[i].DoanhSo)
                    {
                        tempt = result[i];
                        result[i] = result[j];
                        result[j] = tempt;
                    }
                }
            }

            return View(result);

        }






      public IActionResult GioHangKhachHang()  // id lấy từ form index 
        {

            var reqUrl = Request.HttpContext.Request;
            var urlPath = reqUrl.Path;
            var Id = urlPath.ToString().Split('/').Last();

            // xuống bảng lấy tên đăng nhập lên 
            var tk = _db.TkDangNhaps.Where(p => p.Id == int.Parse(Id.ToString())).ToList();
            ViewBag.Name = tk[0].Ten;
            return View(_db.DonHangs.Where(p => p.IDUser == Id.ToString()).ToList());
        }

    }
}
