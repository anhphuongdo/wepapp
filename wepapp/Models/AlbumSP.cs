namespace wepapp.Models
{
    public class AlbumSP
    {
        public string MaAlbum {  get; set; }
        public string MaSP { get; set; }
        public string Hinh { get; set; }
        public AlbumSP() {  }
        public AlbumSP(string maAlbum, string maSP, string hinh)
        {
            MaAlbum = maAlbum;
            MaSP = maSP;
            Hinh = hinh;
        }
    }
}
