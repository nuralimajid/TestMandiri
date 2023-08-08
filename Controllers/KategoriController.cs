using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestMandiri.Models;
using TestMandiri.Repository.Interfaces;

namespace TestMandiri.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KategoriController : ControllerBase
    {
        private readonly IKategoriRepository _kategoriRepository;
        public KategoriController(IKategoriRepository kategoriRepository)
        {
            _kategoriRepository = kategoriRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Kategori>> Getall()
        {
            _kategoriRepository.GetAll();
            return Ok();
        }

        [HttpGet("{id}")]
        public ActionResult<Kategori> GetKategoriById(int id)
        {
            var getKategori = _kategoriRepository.GetKategoriById(id);
            if (getKategori == null)
            {
                return NotFound();
            }
            return Ok(getKategori);
        }

        [HttpPost]
        public ActionResult<Kategori> Addkategori(Kategori kategori)
        {
            _kategoriRepository.addKategori(kategori);
            return CreatedAtAction(nameof(GetKategoriById), new { id = kategori.Id }, kategori);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateKategori(int id, Kategori kategori)
        {
            var getKategori = _kategoriRepository.GetKategoriById(id);
            if(getKategori == null)
            {
                return NotFound();
            }
            kategori.Id = id;
            _kategoriRepository.updateKategori(kategori);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteKategori(int id)
        {
            var getKategori = _kategoriRepository.GetKategoriById(id);
            if(getKategori == null)
            {
                return NotFound();
            }
            _kategoriRepository.deleteKategori(id);
            return NoContent();
        }

    }
}
