using TestMandiri.Models;

namespace TestMandiri.Repository.Interfaces
{
    public interface IKategoriRepository
    {
        IEnumerable<Kategori> GetAll();
        Kategori GetKategoriById(int id);
        void addKategori (Kategori kategori);
        void updateKategori (Kategori kategori);
        void deleteKategori (int id);
    }
}
