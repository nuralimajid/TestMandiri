using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestMandiri.Models;
using TestMandiri.Repository.Interfaces;

namespace TestMandiri.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BukuController : ControllerBase
    {
        private IBukuRepository _bukuRepository;
        public BukuController(IBukuRepository bukuRepository)
        {
            _bukuRepository = bukuRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Buku>> GetAll()
        {
            var Bukus = _bukuRepository.GetAll();
            return Ok(Bukus);
        }
        [HttpGet("{id}")]
        public ActionResult<Buku> GetBukuById(int id)
        {
            var buku = _bukuRepository.GetBukuById(id);
            if(buku == null)
            {
                return NotFound();
            }
            return Ok(buku);
        }

        [HttpPost]
        public ActionResult<Buku> addBuku(Buku buku)
        {
            _bukuRepository.addBuku(buku);
            return CreatedAtAction(nameof(GetBukuById), new { id = buku.Id }, buku);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateBuku(int id, Buku buku)
        {
            var getBuku = _bukuRepository.GetBukuById(id);
            if (getBuku == null)
            {
                return NotFound();
            }
            buku.Id = id;
            _bukuRepository.updateBuku(buku);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBuku (int id)
        {
            var getBuku = _bukuRepository.GetBukuById(id);
            if(getBuku == null)
            {
                return NotFound();
            }
            _bukuRepository.deleteBuku(id);
            return NoContent();
        }

    }
}
