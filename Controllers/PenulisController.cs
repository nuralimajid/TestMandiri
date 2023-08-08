using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestMandiri.Models;
using TestMandiri.Repository.Interfaces;

namespace TestMandiri.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PenulisController : ControllerBase
    {
        private readonly IPenulisRepository _penulisRepository;
        public PenulisController(IPenulisRepository penulisRepository)
        {
            _penulisRepository = penulisRepository;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Penulis>> GetAll()
        {
            var penulis = _penulisRepository.GetAll();
            return Ok(penulis);
        }
        [HttpGet("{id}")]
        public ActionResult<Penulis> GetPenulisById(int id)
        {
            var getPenulis = _penulisRepository.GetPenulisById(id);
            if(getPenulis == null)
            {
                return NotFound();
            }
            return Ok(getPenulis);
        }

        [HttpPost]
        public ActionResult<Penulis> AddPenulis (Penulis penulis)
        {
            _penulisRepository.addPenulis(penulis);
            return CreatedAtAction(nameof(GetPenulisById), new {id = penulis.Id}, penulis);
        }
        [HttpPut("{id}")]
        public IActionResult UpdatePenulis(int id, Penulis penulis)
        {
            var getPenulis = _penulisRepository.GetPenulisById(id);
            if (getPenulis == null)
            {
                return NotFound();
            }

            penulis.Id = id;
            _penulisRepository.updatePenulis(penulis);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult DeletePenulisById(int id)
        {
            var getPenulis = _penulisRepository.GetPenulisById(id);
            if( getPenulis == null)
            {
                return NotFound();
            }
            _penulisRepository.deletePenulisById(id);
            return NoContent();
        }
    }
}
