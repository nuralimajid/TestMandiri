using TestMandiri.Data;
using TestMandiri.Models;
using TestMandiri.Repository.Interfaces;

namespace TestMandiri.Repository
{
    public class KategoriRepository : IKategoriRepository
    {
        private readonly AppDBContext _Context;
        public KategoriRepository(AppDBContext context)
        {
            _Context = context;
        }

        public void addKategori(Kategori kategori)
        {
            _Context.Kategori.Add(kategori);
            _Context.SaveChanges();
        }

        public IEnumerable<Kategori> GetAll()
        {
            return _Context.Kategori.ToList();
        }

        public Kategori GetKategoriById(int id)
        {
            return _Context.Kategori.FirstOrDefault(x => x.Id == id);
        }

        public void updateKategori(Kategori kategori)
        {
            _Context.Kategori.Update(kategori);
            _Context.SaveChanges();
        }

        public void deleteKategori(int id)
        {
            var kategoriId = _Context.Kategori.FirstOrDefault(x=>x.Id == id);
            if(kategoriId != null)
            {
                _Context.Remove(kategoriId);
                _Context.SaveChanges();
            }
        }
    }
}
