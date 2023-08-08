using Microsoft.EntityFrameworkCore;
using TestMandiri.Data;
using TestMandiri.Models;
using TestMandiri.Repository.Interfaces;

namespace TestMandiri.Repository
{
    public class BukuRepository : IBukuRepository
    {
        private readonly AppDBContext _Context;

        public BukuRepository(AppDBContext context)
        {
            _Context = context;
        }

        public void addBuku(Buku buku)
        {
            _Context.Buku.Add(buku);
            _Context.SaveChanges();
        }

        public void deleteBuku(int id)
        {
            var BukuId = _Context.Buku.FirstOrDefault(x => x.Id == id);
            if (BukuId != null)
            {
                _Context.Remove(BukuId);
                _Context.SaveChanges();
            }
        }

        public IEnumerable<Buku> GetAll()
        {
            return _Context.Buku.ToList();
        }

        public Buku GetBukuById(int id)
        {
            return _Context.Buku.FirstOrDefault(x => x.Id == id);
        }

        public void updateBuku(Buku buku)
        {
            _Context.Update(buku);
            _Context.SaveChanges();
        }
    }
}
