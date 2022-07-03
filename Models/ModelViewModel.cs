using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace vroom2.Models
{
    public class ModelViewModel
    {// chọn 1 trong nhiều Make cho Model 
        public Model Model { get; set; }
        public IEnumerable<Make> Makes { get; set; }


        // SelectListItem lấy của MVC Rendering 
        // hiện lên danh sách những thằng Make 
        public IEnumerable<SelectListItem> CSelectListItem(IEnumerable<Make> Items) // truyền vào 1 danh sách Make 
        {
            List<SelectListItem> MakeList = new List<SelectListItem>();
            SelectListItem sli = new SelectListItem
            {
                Text = "----Select----",
                Value = "0"
            };
            MakeList.Add(sli);
            foreach (Make make in Items)
            {
                sli = new SelectListItem { 
                    Text=make.Name,
                    Value=make.Id.ToString()
                };
                MakeList.Add(sli);
            }
            return MakeList;  // trả về 1 selectlist 
            // Gồm các Name của thằng danh sách Make truyền vào 
        }
           
    }
        
 }

