using TestMandiri.Data;
using TestMandiri.Models;
using TestMandiri.Repository.Interfaces;

namespace TestMandiri.Repository
{
    public class PenulisRepository : IPenulisRepository
    {
        private readonly AppDBContext _Context;
        public PenulisRepository(AppDBContext context)
        {
            _Context = context;
        }

        public void addPenulis(Penulis penulis)
        {
            _Context.Penulis.Add(penulis);
            _Context.SaveChanges();
        }

        public void deletePenulisById(int id)
        {
            var penulisId = _Context.Penulis.FirstOrDefault(x=>x.Id == id);
            if(penulisId != null)
            {
                _Context.Remove(penulisId);
                _Context.SaveChanges();
            }
        }

        public IEnumerable<Penulis> GetAll()
        {
            return _Context.Penulis.ToList();
        }

        public Penulis GetPenulisById(int id)
        {
            return _Context.Penulis.FirstOrDefault(x=>x.Id == id);
        }

        public void updatePenulis(Penulis penulis)
        {
            _Context.Penulis.Update(penulis);
            _Context.SaveChanges();
        }

    }
}
