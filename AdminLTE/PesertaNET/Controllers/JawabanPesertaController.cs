using PesertaNET.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PesertaNET.Controllers
{
    public class JawabanPesertaController : ApiController
    {
        private TesttimemeEntities db = new TesttimemeEntities();
        // GET: api/JawabanPeserta
        public int Get([FromUri]int idSoal, [FromUri] int idPeserta, [FromUri] String Jawaban)
        {
            Debug.WriteLine(idSoal);
            Debug.WriteLine(idPeserta);
            Debug.WriteLine(Jawaban);
            peserta_jawaban_detail isi = new peserta_jawaban_detail()
            {
                soal_id = idSoal,
                pesertatest_id = idPeserta,
                jawaban_peserta = Jawaban

            };
            db.peserta_jawaban_detail.Add(isi);
            return db.SaveChanges();
        }

        // GET: api/JawabanPeserta/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/JawabanPeserta
        //[HttpPost]
        public void Post([FromUri]int idSoal, [FromUri] int idPeserta, [FromUri] String Jawaban)
        {
            


        }

        // PUT: api/JawabanPeserta/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/JawabanPeserta/5
        public void Delete(int id)
        {
        }
    }
}
