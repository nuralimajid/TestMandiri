using TestMandiri.Models;

namespace TestMandiri.Repository.Interfaces
{
    public interface IBukuRepository
    {
        IEnumerable<Buku> GetAll();
        Buku GetBukuById(int id);
        void addBuku(Buku buku);
        void updateBuku(Buku buku);
        void deleteBuku(int id);
    }
}
