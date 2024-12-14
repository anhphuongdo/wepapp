namespace wepapp.Models
{
    public class LoaiSP
    {
        public string MaLoai { get; set; }
        public string TenLoai { get; set; }
        public string TrangThai { get; set; }
        public LoaiSP() { }
        public LoaiSP(string maLoai, string tenLoai, string trangThai)
        {
            MaLoai = maLoai;
            TenLoai = tenLoai;
            TrangThai = trangThai;
        }
    }
}
