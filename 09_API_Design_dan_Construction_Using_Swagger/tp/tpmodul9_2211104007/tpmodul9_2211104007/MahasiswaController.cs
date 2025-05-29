using Microsoft.AspNetCore.Mvc;
using tpmodul9_2211104007.Models;
using tpmodul9_2211104007;

namespace tpmodul9_2211104007.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa { Nama = "Andera Singgih Pratama", Nim = "2211104007" },
            new Mahasiswa { Nama = "Ahmad Junaidi", Nim = "2211104002" },
            new Mahasiswa { Nama = "Dewi Atika Muthi", Nim = "2211104042" },
            new Mahasiswa { Nama = "Muhammad Abdul Aziz", Nim = "2211104026" },
        };

        // GET /api/mahasiswa
        [HttpGet]
        public ActionResult<List<Mahasiswa>> GetAll()
        {
            return daftarMahasiswa;
        }

        // GET /api/mahasiswa/{index}
        [HttpGet("{index}")]
        public ActionResult<Mahasiswa> GetByIndex(int index)
        {
            if (index < 0 || index >= daftarMahasiswa.Count)
                return NotFound();

            return daftarMahasiswa[index];
        }

        // POST /api/mahasiswa
        [HttpPost]
        public ActionResult AddMahasiswa(Mahasiswa mhs)
        {
            daftarMahasiswa.Add(mhs);
            return Ok();
        }

        // DELETE /api/mahasiswa/{index}
        [HttpDelete("{index}")]
        public ActionResult DeleteMahasiswa(int index)
        {
            if (index < 0 || index >= daftarMahasiswa.Count)
                return NotFound();

            daftarMahasiswa.RemoveAt(index);
            return Ok();
        }
    }
}
