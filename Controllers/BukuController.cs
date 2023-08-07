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
        public IActionResult<IEnumerable<Buku>> GetAll()
        {
            var Bukus = _bukuRepository.GetAll();
            return Ok(Bukus);
        }
    }
}
