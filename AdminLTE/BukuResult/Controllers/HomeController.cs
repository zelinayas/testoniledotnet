using BukuResult.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BukuResult.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //Post action for Save data to database
        [HttpPost]
        public JsonResult SavePinjam(Peminjaman O)
        {
            bool status = false;
            if (ModelState.IsValid)
            {
                using (BukuEntities dc = new BukuEntities())
                {
                    detailPinjam order = new detailPinjam();
                    notaPinjam not = new notaPinjam { tanggalPinjam = O.tanggalPinjam};
                    foreach (var i in O.detailpinjam)
                    {
                        
                        not.detailPinjam.Add(i);
                    }
                    //dc.detailPinjam.Add(order);
                    dc.notaPinjam.Add(not);
                    dc.SaveChanges();
                    status = true;
                }
            }
            else
            {
                status = false;
            }
            return new JsonResult { Data = new { status = status } };
        }


        [HttpPost]
        public JsonResult Tambah(Peminjaman a)
        {
            bool status = false;
            if (ModelState.IsValid)
            {

                using (BukuEntities op = new BukuEntities())
                {
                    buku aspek = new buku { judul = a.judul};
                    notaPinjam nota = new notaPinjam { tanggalPinjam = a.tanggalPinjam };

                    foreach (var item in a.detailpinjam)
                    {

                        aspek.detailPinjam.Add(item);
                        nota.detailPinjam.Add(item);
                    }
                    op.buku.Add(aspek);
                    op.notaPinjam.Add(nota);
                    op.SaveChanges();
                    status = true;
                }
            }
            else
            {
                status = false;
            }
            return new JsonResult { Data = new { status = status } };
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}