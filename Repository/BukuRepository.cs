using TestMandiri.Models;
using TestMandiri.Repository.Interfaces;

namespace TestMandiri.Repository
{
    public class BukuRepository : IBukuRepository
    {
        private readonly AppDBContext _Context;

        public void addBuku(Buku buku)
        {
            throw new NotImplementedException();
        }

        public void deleteBuku(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Buku> GetAll()
        {
            throw new NotImplementedException();
        }

        public Buku GetBukuById(int id)
        {
            throw new NotImplementedException();
        }

        public void updateBuku(Buku buku)
        {
            throw new NotImplementedException();
        }
    }
}
