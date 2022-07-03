using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using vroom2.AppDbContext;
using vroom2.Models;

namespace vroom2.Controllers
{
    public class ModelController : Controller
    {
        private readonly VroomDbContext _db;

        [BindProperty]
        public ModelViewModel ModelVM{get;set;}
        // contructor 
        public ModelController(VroomDbContext db)
        {
            _db = db;
            ModelVM = new ModelViewModel()
            {
                Makes=_db.Makes.ToList(), // lấy dữ liệu từ bảng bảng Make 
                Model=new Models.Model()
            };
        }

        public IActionResult Index()
        {
            // truyền vào 1 danh sách Model ( gồm cả thằng Make ở trong) 
            var model = _db.Models.Include(m=>m.Make);// 1 danh sách models 
            return View(model);
        }


         // get 
        public IActionResult Create()
        {
             
            return View(ModelVM); // trả về view để hiển thị ; đưa vào ViewVM để điền rồi lấy ra cho CraetePost 
        }
        
        [HttpPost]
        // điền xong thì trả về dữ liệu 
        public IActionResult CreatePost()
        {
            if (!ModelState.IsValid)
            {
               return View(ModelVM);
            }
            _db.Models.Add(ModelVM.Model);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }



        // edit 
        // tìm kiếm model thích hợp của ViewModel dựa trên Id truyền vào 
        public IActionResult Edit()  
        {
            // truyền vào 1 id từ trang index(Model) 
            var reqUrl = Request.HttpContext.Request;
            var urlPath = reqUrl.Path;
            var id = urlPath.ToString().Split('/').Last();

            // tìm đc thằng model phù hợp với id đấy và gán cho Model của ModelViewModel 
            ModelVM.Model = _db.Models.Include(m => m.Make).SingleOrDefault(m => m.Id == int.Parse(id));// gán giá trị của thuộc tính model bằng id 
            if (ModelVM.Model == null)
            {
                return NotFound();
            };
            return View(ModelVM); // truyền vào 
        }
        [HttpPost]
        public IActionResult EditPost()
        {
            if (!ModelState.IsValid)
            {
                return View(ModelVM);
            }
            _db.Models.Update(ModelVM.Model);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index)); // index của thằng ModelController 
        }



        // lấy thông tin từ form trên index 
        [HttpPost]
        public IActionResult Delete(int id)
        {  
            Model model = _db.Models.Find(id); // tìm trong bangr Models 
            if (model == null)
            {
                return NotFound();
            }
            _db.Models.Remove(model);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
