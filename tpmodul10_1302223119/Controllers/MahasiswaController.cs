using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace tpmodul10_1302223119.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        public static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa("Muhammad Faisal Shafwan Damanik", "1302223119"),
            new Mahasiswa("Kyntar Barra Langit Lubis", "1302220113"),
            new Mahasiswa("Yoga Fifri Rizkulloh", "1302220101"),
            new Mahasiswa("Haidar Abdul Halim", "1302220152")
        };

        [HttpGet]
        public IEnumerable<Mahasiswa> GetDaftar()
        {
            return daftarMahasiswa;
        }

        [HttpPost]
        public string PostMahasiswa([FromBody] Mahasiswa ms)
        {
            daftarMahasiswa.Add(ms);

            return $"{ms.Nama} berhasil dimasukan ke daftar";
        }

        [HttpGet("{id}")]
        public Mahasiswa GetMahasiswa(int id)
        {
            return daftarMahasiswa[id];
        }

        [HttpDelete("{id}")]
        public string DeleteMahasiswa(int id)
        {
            daftarMahasiswa.RemoveAt(id);

            return $"{daftarMahasiswa[id].Nama} berhasil dihapus ke daftar";
        }
    }
}