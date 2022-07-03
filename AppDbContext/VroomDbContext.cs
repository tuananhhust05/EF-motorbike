using Microsoft.EntityFrameworkCore;

using vroom2.Models;

namespace vroom2.AppDbContext
{
    public class VroomDbContext : DbContext// kế thừa 
    {
        public VroomDbContext(DbContextOptions<VroomDbContext> options) : 
            base(options)
        {
        }  // tạo Database 
    
        
        public DbSet<Make> Makes { get; set;  }
        public DbSet<Model> Models { get; set; }
        public DbSet<TkDangNhap> TkDangNhaps { get; set; }

        public DbSet<DonHang> DonHangs { get; set; }
    }
}
