namespace vroom2.Models
{
    public class DonHang
    {
        public int ID { get; set; }
        public string IDUser { get; set; }  // sửa thành string cho chắc 
        public string IDModels { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Price { get; set; }

        public string HoTen { get; set; }
        public string SDT { get; set; }
        public string NgayXemXe { get; set; }
        public string TinhTrang { get; set; }
    }
}
