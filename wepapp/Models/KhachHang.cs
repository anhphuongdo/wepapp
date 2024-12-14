namespace wepapp.Models
{
    public class KhachHang
    {
        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string Email { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChiNhanHang { get; set; }

        public KhachHang() { }
        public KhachHang(string maKH, string tenKH, string taiKhoan, string matKhau, DateTime ngaySinh, string gioiTinh, string email, string soDienThoai, string diaChiNhanHang)
        {
            MaKH = maKH;
            TenKH = tenKH;
            TaiKhoan = taiKhoan;
            MatKhau = matKhau;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            Email = email;
            SoDienThoai = soDienThoai;
            DiaChiNhanHang = diaChiNhanHang;
        }
    }
}
