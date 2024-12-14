namespace wepapp.Models
{
    public class DonHang
    {
        public string MaDonHang { get; set; }
        public string MaKH { get; set; }
        public string MaCTKM { get; set; }
        public int TongTien { get; set; }
        public int PhuongThucThanhToan { get; set; }
        public string DiaChiNhanHang { get; set; }

        public DonHang() { }
        public DonHang(string maDonHang, string maKH, string maCTKM, int tongTien, int phuongThucThanhToan, string diaChiNhanHang)
        {
            MaDonHang = maDonHang;
            MaKH = maKH;
            MaCTKM = maCTKM;
            TongTien = tongTien;
            PhuongThucThanhToan = phuongThucThanhToan;
            DiaChiNhanHang = diaChiNhanHang;
        }
    }
}
