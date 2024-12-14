namespace wepapp.Models
{
    public class DanhGia
    {
        public string MaDanhGia { get; set; }
        public string MaKH {  get; set; }
        public string MaSP { get; set; }
        public string NoiDung { get; set; }
        public string Hinh {  get; set; }

        public DanhGia() { }

        public DanhGia(string maDanhGia, string maKH, string maSP, string noiDung, string hinh)
        {
            MaDanhGia = maDanhGia;
            MaKH = maKH;
            MaSP = maSP;
            NoiDung = noiDung;
            Hinh = hinh;
        }
    }
}
