using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using vroom2.AppDbContext;
using vroom2.Models;

namespace vroom2.Controllers
{
    public class HomePageController : Controller
    {
        private readonly VroomDbContext _db;


        // contructor 
        public HomePageController(VroomDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }






        [HttpGet]
        public IActionResult DangNhap()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DangNhap(string IP, string pw)
        {   
            // IP là tên 
            // nhứo phải đúng tên trên view 
            
            var tk = _db.TkDangNhaps.Find(1);  // lấy tài khoản admin lên 

            // đối chiếu với tk admin 
            if ((tk.PassWord == pw)&&(tk.Ten==IP))
            {   
                return RedirectToAction("Index","Make");
            }
            else
            {   // tài khoản user  id khác 1
                // tên đăng nhập không đc trùng 
                var tk2 = _db.TkDangNhaps.Where(p => p.Ten == IP).ToList();
               
                if (tk2[0].PassWord == pw)
                {
                    HttpContext.Session.SetString("DangNhapSession", JsonConvert.SerializeObject(tk2[0])); // lưu thông tin đăng nhập 
                    return RedirectToAction("Index", "User");
                }
            }
            return View();
        }




        [HttpGet]
        public IActionResult DangKy()
        {
            ViewBag.Name = "Xin chào";
            return View();
           
        }
        [HttpPost]
        public IActionResult DangKy(string Ten,string pw,string pw2)
        {
            TkDangNhap tk = new TkDangNhap();
            tk.Ten = Ten;
            tk.PassWord = pw;

            // cehck xem có trùng tên không 
            var check = _db.TkDangNhaps.Where(p => p.Ten == Ten); // cái này luôn khác null; ta cần quy ra list
            if (pw == pw2)
            { if (check.ToList().Count == 0)
                {
                    if (ModelState.IsValid)   // điều kiện để duyệt 
                    {
                        _db.Add(tk);
                        _db.SaveChanges();
                        ViewBag.Name = "Đăng ký thành công";

                    }
                    else
                    {
                        ViewBag.Name = "Đăng ký thành công do ModelState is not valid, có thể do bạn để tên đăng nhập hoặc mặt khẩu quá dài ";
                    }
                }
                else
                {
                    ViewBag.Name = "Tên đăng nhập bị trùng, vui lòng nhập lại";
                }
              
            }
            else
            {
                ViewBag.Name = "Xác nhận mật khẩu không thành công ";
                
            };
            return View();
        }
    }
}
