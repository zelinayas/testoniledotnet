using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using NLog;
using NLog.Config;
using PesertaNET.Models;

namespace PesertaNET.Controllers
{
    public class peserta_jawaban_detailController : Controller
    {
        private TesttimemeEntities db = new TesttimemeEntities();
        private Logger logger = NLog.LogManager.GetCurrentClassLogger();

        // GET: peserta_jawaban_detail
        public ActionResult Index()
        {
            var peserta_jawaban_detail = db.peserta_jawaban_detail.Include(p => p.soal).Include(p => p.peserta_test);
            return View(peserta_jawaban_detail.ToList());
        }
        public ActionResult Login()
        {
           
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(peserta objUser)
        {
            if (ModelState.IsValid)
            {
                using (TesttimemeEntities dc = new TesttimemeEntities())
                {
                    var obj = db.peserta.Where(a => a.email.Equals(objUser.email) && a.password.Equals(objUser.password)).FirstOrDefault();
                    if (obj != null)
                    {
                       
                        Session["email"] = obj.email.ToString();
                        Session["password"] = obj.password.ToString();
                       
                        return RedirectToAction("HalamanPeraturanSoal", "peserta_jawaban_detail");
                    }
                }
            }
            else
            {
                ModelState.AddModelError("", "");
            }
            return View(objUser);
        }

        public ActionResult HalamanPeraturanSoal()
        {
            if (Session["email"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Login", "peserta_jawaban_detail");
        }


        public ActionResult HalamanSoal(int? id)
        {

            if (!id.HasValue) id = 1;

            var soalf = from soalm in db.soal
                        where soalm.id == id
                        select soalm;
            if (soalf.Count() != 1)
            {
                return View("HalamanTerimaKasih");
            }
            return View(soalf.Single());
        }

        public ActionResult HalamanTerimaKasih()
        {
            
            return View();
        }

        public ActionResult Halaman()
        {

            return View();
        }

        // GET: peserta_jawaban_detail/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            peserta_jawaban_detail peserta_jawaban_detail = db.peserta_jawaban_detail.Find(id);
            if (peserta_jawaban_detail == null)
            {
                return HttpNotFound();
            }
            return View(peserta_jawaban_detail);
        }

        // GET: peserta_jawaban_detail/Create
        public ActionResult Create()
        {
            ViewBag.soal_id = new SelectList(db.soal, "id", "create_by");
            ViewBag.pesertatest_id = new SelectList(db.peserta_test, "id", "create_by");
            return View();
        }

        // POST: peserta_jawaban_detail/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,create_by,create_date,keterangan,status,update_by,update_date,jawaban_peserta,pesertatest_id,soal_id")] peserta_jawaban_detail peserta_jawaban_detail)
        {
            if (ModelState.IsValid)
            {
                db.peserta_jawaban_detail.Add(peserta_jawaban_detail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.soal_id = new SelectList(db.soal, "id", "create_by", peserta_jawaban_detail.soal_id);
            ViewBag.pesertatest_id = new SelectList(db.peserta_test, "id", "create_by", peserta_jawaban_detail.pesertatest_id);
            return View(peserta_jawaban_detail);
        }

        // GET: peserta_jawaban_detail/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            peserta_jawaban_detail peserta_jawaban_detail = db.peserta_jawaban_detail.Find(id);
            if (peserta_jawaban_detail == null)
            {
                return HttpNotFound();
            }
            ViewBag.soal_id = new SelectList(db.soal, "id", "create_by", peserta_jawaban_detail.soal_id);
            ViewBag.pesertatest_id = new SelectList(db.peserta_test, "id", "create_by", peserta_jawaban_detail.pesertatest_id);
            return View(peserta_jawaban_detail);
        }

        // POST: peserta_jawaban_detail/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,create_by,create_date,keterangan,status,update_by,update_date,jawaban_peserta,pesertatest_id,soal_id")] peserta_jawaban_detail peserta_jawaban_detail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(peserta_jawaban_detail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.soal_id = new SelectList(db.soal, "id", "create_by", peserta_jawaban_detail.soal_id);
            ViewBag.pesertatest_id = new SelectList(db.peserta_test, "id", "create_by", peserta_jawaban_detail.pesertatest_id);
            return View(peserta_jawaban_detail);
        }

        // GET: peserta_jawaban_detail/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            peserta_jawaban_detail peserta_jawaban_detail = db.peserta_jawaban_detail.Find(id);
            if (peserta_jawaban_detail == null)
            {
                return HttpNotFound();
            }
            return View(peserta_jawaban_detail);
        }

        // POST: peserta_jawaban_detail/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            peserta_jawaban_detail peserta_jawaban_detail = db.peserta_jawaban_detail.Find(id);
            db.peserta_jawaban_detail.Remove(peserta_jawaban_detail);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
