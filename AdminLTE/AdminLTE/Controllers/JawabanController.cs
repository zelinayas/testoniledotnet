using NLog;
using PesertaNET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PesertaNET.Controllers
{
    public class JawabanController : ApiController
    {
        
        private TesttimemeEntities db = new TesttimemeEntities();
        private Logger logger = NLog.LogManager.GetCurrentClassLogger();
        // GET api/<controller>
        public List<string> Get()
        {
            var x = from f in db.peserta_jawaban_detail
                    select f.jawaban_peserta;
            return x.ToList();

        }
        // GET api/<controller>/5
        public string Get(int id)
        {
            
            var x = from f in db.peserta_jawaban_detail
                        //where f.jawaban_peserta != null
                    select f.jawaban_peserta;
            
            return x.Single();
            
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