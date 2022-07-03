using System.ComponentModel.DataAnnotations;

namespace vroom2.Models
{
    public class Model
    {
        public int Id { get; set; }
        // điều kiện cho thằng Name 
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public Make Make { get; set; }  // khóa ngoại liên kể bảng 
        
  
        public int MakeID { get; set; }  // liên hệ với bảng Make 
        public string ImageUrl { get; set; }
        public string Price { get; set; }

    }
}
