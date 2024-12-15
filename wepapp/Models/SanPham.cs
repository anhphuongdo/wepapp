using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wepapp.Models
{
    [Table(nameof(SanPham))]
    public class SanPham
    {
        [Key]
        [StringLength(10)]
        public string MaSP {  get; set; }

        [Required]
        [StringLength(10)]
        public string MaLoai { get; set; }

        [StringLength(50)]
        public string SKU { get; set; }

        [Column(TypeName = "text")]
        public string TenSP { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string MauSac {  get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string ChatLieu { get; set; }

        [Column(TypeName = "text")]
        public string HinhChinh { get; set; }

        [RegularExpression(@"^(Nam|Nữ)$", ErrorMessage = "Giá trị của Giới tính phải là 'Nam' hoặc 'Nữ'")]
        public string GioiTinh { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Giá phải lớn hơn hoặc bằng 0")]
        public int Gia {  get; set; }

        [RegularExpression(@"^(Hiển thị|Ẩn)$", ErrorMessage = "Giá trị của TrangThai phải là 'Hiển thị' hoặc 'Ẩn'")]
        public string TrangThai { get; set; }

        [Column(TypeName = "text")]
        public string Mota { get; set; }
        public DateTime NgayTao { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Giá khuyến mãi phải lớn hơn hoặc bằng 0")]
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
