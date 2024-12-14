namespace wepapp.Models
{
    public class ChiTietDonHang
    {
        public string MaGioHang { get; set; }
        public string MaSP { get; set; }
        public int SoLuong { get; set; }

        public ChiTietDonHang() { }
        public ChiTietDonHang(string maGioHang, string maSP, int soLuong)
        {
            MaGioHang = maGioHang;
            MaSP = maSP;
            SoLuong = soLuong;
        }
    }
}
