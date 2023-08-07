namespace TestMandiri.Models
{
    public class Buku
    {
        public int Id { get; set; }
        public string Judul { get; set; }
        public string ISBN { get; set; }
        public Penulis Penulis { get; set; }
        public int PenulisId { get; set; }
        public Kategori Kategori { get; set; }
        public int KategoriId { get; set; }
    }
}
