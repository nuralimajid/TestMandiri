namespace TestMandiri.Models
{
    public class Penulis
    {
        public int Id { get; set; }
        public string Nama { get; set; }
        public string NamaPena { get; set; }
        public object Buku { get; internal set; }
    }
}
