namespace wepapp.Models
{
    public class SanPham
    {
        public string MaLoai {  get; set; }
        public string MaSP { get; set; }
        public string SKU { get; set; }
        public string TenSP { get; set; }
        public string MauSac {  get; set; }
        public string ChatLieu { get; set; }
        public string HinhChinh { get; set; }
        public string GioiTinh { get; set; }
        public int Gia {  get; set; }
        public string TrangThai { get; set; }
        public string Mota { get; set; }
        public DateTime NgayTao { get; set; }
        public int GiaKhuyenMai {  get; set; }

        public SanPham() { }
        public SanPham(string maLoai, string maSP, string sKU, string tenSP, string mauSac, string chatLieu, string hinhChinh, string gioiTinh, int gia, string trangThai, string mota, DateTime ngayTao, int giaKhuyenMai)
        {
            MaLoai = maLoai;
            MaSP = maSP;
            SKU = sKU;
            TenSP = tenSP;
            MauSac = mauSac;
            ChatLieu = chatLieu;
            HinhChinh = hinhChinh;
            GioiTinh = gioiTinh;
            Gia = gia;
            TrangThai = trangThai;
            Mota = mota;
            NgayTao = ngayTao;
            GiaKhuyenMai = giaKhuyenMai;
        }
    }
}
