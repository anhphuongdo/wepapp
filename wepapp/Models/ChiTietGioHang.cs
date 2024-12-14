namespace wepapp.Models
{
    public class ChiTietGioHang
    {
        public string MaGioHang { get; set; }
        public string MaSP { get; set; }
        public int SoLuong { get; set; }

        public ChiTietGioHang() { }
        public ChiTietGioHang(string maGioHang, string maSP, int soLuong)
        {
            MaGioHang = maGioHang;
            MaSP = maSP;
            SoLuong = soLuong;
        }
    }
}
