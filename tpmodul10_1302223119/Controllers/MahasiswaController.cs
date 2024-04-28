using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace tpmodul10_1302223119.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        private string[] Siswa = new[]
        {
            "siswa1", "siswa2", "siswa3"
        };

        [HttpGet]
        public IEnumerable<string> GetSiswa()
        {
            return Siswa;
        }
    }
}
