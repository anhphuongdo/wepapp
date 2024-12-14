namespace wepapp.Models
{
    public class GioHang
    {
        public int MaGioHang { get; set; }
        public string MaKH { get; set; }

        public GioHang() { }
        public GioHang(int maGioHang, string maKH)
        {
            MaGioHang = maGioHang;
            MaKH = maKH;
        }
    }
}
