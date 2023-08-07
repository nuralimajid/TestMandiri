using TestMandiri.Models;

namespace TestMandiri.Repository.Interfaces
{
    public interface IPenulisRepository
    {
        IEnumerable<Penulis> GetAll();
        Penulis GetPenulisById (int id);
        void addPenulis (Penulis penulis);
        void updatePenulis(Penulis penulis);
        void deletePenulisById (int id);
    }
}
