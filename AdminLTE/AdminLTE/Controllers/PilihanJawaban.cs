using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AdminLTE.Models;
using NLog;

namespace AdminLTE.Controllers
{
    public class PilihanJawaban : ApiController
    {
        private TesttimemeEntities db = new TesttimemeEntities();
        private Logger logger = NLog.LogManager.GetCurrentClassLogger();
        // GET api/<controller>
        public List<peserta_jawaban_detail> Get()
        {
            var d = from f in db.peserta_jawaban_detail
                    //where db.peserta_jawaban_detail == 
                    select f.jawaban_peserta;
            return db.peserta_jawaban_detail.ToList();
            
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}