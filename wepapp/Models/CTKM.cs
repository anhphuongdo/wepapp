namespace wepapp.Models
{
    public class CTKM
    {
        public string MaCTKM { get; set; }
        public string TenCTKM { get; set; }
        public string NoiDung { get; set; }
        public DateTime NgayBatDau {  get; set; }
        public DateTime NgayKetThuc {  get; set; }
        public string LoaiCTKM { get; set; }
        public int SoTienMuaToiThieu { get; set; }
        public int SoTienDuocGiam {  get; set; }

        public CTKM() { }
        public CTKM(string maCTKM, string tenCTKM, string noiDung, DateTime ngayBatDau, DateTime ngayKetThuc, string loaiCTKM, int soTienMuaToiThieu, int soTienDuocGiam)
        {
            MaCTKM = maCTKM;
            TenCTKM = tenCTKM;
            NoiDung = noiDung;
            NgayBatDau = ngayBatDau;
            NgayKetThuc = ngayKetThuc;
            LoaiCTKM = loaiCTKM;
            SoTienMuaToiThieu = soTienMuaToiThieu;
            SoTienDuocGiam = soTienDuocGiam;
        }
    }
}
