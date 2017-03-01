using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ElektronskeSednice.Models;

namespace ElektronskeSednice.Controllers
{
    public class SEDNICEsController : Controller
    {
        private E_Sednice_Indjija_newEntities1 db = new E_Sednice_Indjija_newEntities1();

        // GET: SEDNICEs
        public ActionResult Index()
        {
            var sEDNICEs = db.SEDNICEs.Include(s => s.KORISNIK).Include(s => s.SUBJEKAT1).Include(s => s.TIP_SEDNICE1).Where(s => s.Zavrsena == false & s.DATUM > DateTime.Now);
            return View(sEDNICEs.ToList());
        }

        public ActionResult Administracija(string message = "")
        {
            var sEDNICEs = db.SEDNICEs.Include(s => s.KORISNIK).Include(s => s.SUBJEKAT1).Include(s => s.TIP_SEDNICE1).Where(s => s.Zavrsena == false & s.DATUM > DateTime.Now);
            ViewBag.SednicaUneta = message;

            return View(sEDNICEs.ToList());
        }

        // GET: SEDNICEs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SEDNICE sEDNICE = db.SEDNICEs.Find(id);
            if (sEDNICE == null)
            {
                return HttpNotFound();
            }
            return View(sEDNICE);
        }

        // GET: SEDNICEs/Create
        public ActionResult Create()
        {
            var predsedava = db.KORISNIKs.Where(s => s.Aktivan == true).OrderBy(s => s.PREZIME);
            var subjekat = db.SUBJEKATs.Where(s => s.AKTIVAN == true).OrderBy(s => s.NAZIV);
            var tipSednice = db.TIP_SEDNICE.OrderBy(s => s.OPIS);

            ViewBag.Predsedava = new SelectList(predsedava, "ID", "NAZIV");
            ViewBag.SUBJEKAT = new SelectList(subjekat, "ID", "NAZIV");
            ViewBag.TIP_SEDNICE = new SelectList(db.TIP_SEDNICE, "ID", "OPIS");

            return View();
        }

        // POST: SEDNICEs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,BROJ,SUBJEKAT,DATUM,TIP_SEDNICE,Predsedava,zavodni_broj,mesto,na_osnovu")] SEDNICE sEDNICE)
        {
            if (ModelState.IsValid)
            {
                db.SEDNICEs.Add(sEDNICE);
                db.SaveChanges();
                //return RedirectToAction("Index");

                //                ViewBag.SednicaUneta = "Uspešno uneta sednica";

                //var korisnikSubjekat = db.KORISNIK_SUBJEKAT.Include(s => s.KORISNIK).Include(s => s.SUBJEKAT).Where(s => s.KORISNIK.Aktivan == true);
                //return Administracija("Uspešno uneta sednica");
                return RedirectToAction("Administracija", new{message = "Uspešno uneta sednica"});//, korisnikSubjekat.ToList());
            }

            ViewBag.Predsedava = new SelectList(db.KORISNIKs, "ID", "IME", sEDNICE.Predsedava);
            ViewBag.SUBJEKAT = new SelectList(db.SUBJEKATs, "ID", "NAZIV", sEDNICE.SUBJEKAT);
            ViewBag.TIP_SEDNICE = new SelectList(db.TIP_SEDNICE, "ID", "OPIS", sEDNICE.TIP_SEDNICE);
            return View(sEDNICE);
        }

        // GET: SEDNICEs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SEDNICE sEDNICE = db.SEDNICEs.Find(id);
            if (sEDNICE == null)
            {
                return HttpNotFound();
            }

            var predsedava = db.KORISNIKs.Where(s => s.Aktivan == true).OrderBy(s => s.PREZIME);
            var subjekat = db.SUBJEKATs.Where(s => s.AKTIVAN == true).OrderBy(s => s.NAZIV);
            var tipSednice = db.TIP_SEDNICE.OrderBy(s => s.OPIS);

            ViewBag.Predsedava = new SelectList(predsedava, "ID", "NAZIV", sEDNICE.Predsedava);
            ViewBag.SUBJEKAT = new SelectList(subjekat, "ID", "NAZIV", sEDNICE.SUBJEKAT);
            ViewBag.TIP_SEDNICE = new SelectList(db.TIP_SEDNICE, "ID", "OPIS", sEDNICE.TIP_SEDNICE);

            ViewBag.SednicaUneta = "Uspešno promenjena sednica";

            return View(sEDNICE);
        }

        // POST: SEDNICEs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,BROJ,SUBJEKAT,DATUM,TIP_SEDNICE,Predsedava,zavodni_broj,mesto,na_osnovu")] SEDNICE sEDNICE)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sEDNICE).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Administracija");
            }
            ViewBag.Predsedava = new SelectList(db.KORISNIKs, "ID", "IME", sEDNICE.Predsedava);
            ViewBag.SUBJEKAT = new SelectList(db.SUBJEKATs, "ID", "NAZIV", sEDNICE.SUBJEKAT);
            ViewBag.TIP_SEDNICE = new SelectList(db.TIP_SEDNICE, "ID", "OPIS", sEDNICE.TIP_SEDNICE);
            return View(sEDNICE);
        }

        // GET: SEDNICEs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SEDNICE sEDNICE = db.SEDNICEs.Find(id);
            if (sEDNICE == null)
            {
                return HttpNotFound();
            }
            return View(sEDNICE);
        }

        // POST: SEDNICEs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SEDNICE sEDNICE = db.SEDNICEs.Find(id);
            db.SEDNICEs.Remove(sEDNICE);
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

        public ActionResult Pozivanje(int? sednicaID)
        {

            var korisnikSubjekat = db.KORISNIK_SUBJEKAT.Include(s => s.SUBJEKAT).Include(s => s.KORISNIK).Where(s => s.KORISNIK.Aktivan == true).OrderBy(s => s.SUBJEKAT.NAZIV).ThenBy(s => s.KORISNIK.PREZIME).ThenBy(s => s.KORISNIK.IME);
            var pozvaniKorisnici = db.Pozvani_Korisnici.Include(s => s.KORISNIK).Where(s => s.Sednica_ID == sednicaID && s.KORISNIK.Aktivan == true).OrderBy(s => s.KORISNIK.PREZIME).ThenBy(s => s.KORISNIK.IME);
            ViewBag.SednicaId = sednicaID.ToString();

            var model = new PozvaniKorisnici { Korisnik_Subjekat = korisnikSubjekat, Pozvani_Korisnici = pozvaniKorisnici };

            return View(model);
        }

        // GET: SEDNICEs/Details/5
        public ActionResult DnevniRed(int? sednicaID)
        {
            if (sednicaID == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var dnevniRed = db.Tacke_Dnevnog_Reda.Include(s => s.DOKUMENTA).Include(s => s.SUBJEKAT).Where(s => s.Sednica == sednicaID).OrderBy(s => s.Redni_broj);

            if (dnevniRed == null)
            {
                return HttpNotFound();
            }
            return View(dnevniRed.ToList());
        }

        // GET: SEDNICEs/Details/5
        public ActionResult DnevniRedEdit(int? sednicaID)
        {
            if (sednicaID == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var dnevniRed = db.Tacke_Dnevnog_Reda.Include(s => s.DOKUMENTA).Include(s => s.SUBJEKAT).Where(s => s.Sednica == sednicaID).OrderBy(s => s.Redni_broj);

            if (dnevniRed == null)
            {
                return HttpNotFound();
            }

            var subjekat = db.SUBJEKATs.Where(s => s.AKTIVAN == true).OrderBy(s => s.NAZIV);
            ViewBag.SUBJEKAT = new SelectList(subjekat, "ID", "NAZIV");

            return View(dnevniRed.ToList());
        }

        [HttpPost]
        public ActionResult SlanjeObavestenja(List<string> pozvaniClanovi, int sednicaId, bool aplikacija, bool sms, bool mail)
        {
            var message = String.Empty;
            if (pozvaniClanovi != null)
            {
                foreach (string item in pozvaniClanovi)
                {
                    int pozvaniClanID = int.Parse(item);
                    var korisnikJePozvan = db.Pozvani_Korisnici.Any(s => s.Korisnik_ID == pozvaniClanID && s.Sednica_ID == sednicaId);

                    var pozvani = new Pozvani_Korisnici();
                    pozvani.Korisnik_ID = int.Parse(item);
                    pozvani.Sednica_ID = sednicaId;
                    pozvani.Mail = mail;
                    pozvani.Sistem = aplikacija;
                    pozvani.SMS = sms;

                    if (!korisnikJePozvan) // ukoliko korisnik nije pozvan ubacujemo ga u tabelu
                    {
                        db.Pozvani_Korisnici.Add(pozvani);
                        db.SaveChanges();
                    }
                    else
                    {
                        var pozvaniKorisnik = db.Pozvani_Korisnici.First(s => s.Korisnik_ID == pozvaniClanID && s.Sednica_ID == sednicaId);
                        if (aplikacija) pozvaniKorisnik.Sistem = aplikacija;
                        if (mail) pozvaniKorisnik.Mail = mail;
                        if (sms) pozvaniKorisnik.SMS = sms;
                        db.Entry(pozvaniKorisnik).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                }
                message = "ok";
            }
            else
            {
                message = "error";
            }
            return Json(new { message }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult _PozvaniKorisnici(int id)
        {
            return PartialView();
        }

        public JsonResult SacuvajTackuDnevnogReda(string sednicaId, string brojTacke, string nazivTacke, string subjekat)
        {
            for (int i = 0; i < Request.Files.Count; i++)
            {
                HttpPostedFileBase file = Request.Files[i]; //Uploaded file
                //Use the following properties to get file's name, size and MIMEType
                int fileSize = file.ContentLength;
                string fileName = file.FileName;
                string mimeType = file.ContentType;
                System.IO.Stream fileContent = file.InputStream;
                //To save file, use SaveAs method
                file.SaveAs(Server.MapPath("~/Upload") + fileName);

                var dokument = new DOKUMENTA();
                dokument.LINK = Server.MapPath("~/Upload") + fileName;
                db.DOKUMENTAs.Add(dokument);
                db.SaveChanges();
                int idDokumenta = dokument.ID;

                
                var tackeDR = new Tacke_Dnevnog_Reda();
                tackeDR.Naziv_tacke = nazivTacke;
                tackeDR.Sednica = int.Parse(sednicaId);
                tackeDR.predlagac = int.Parse(subjekat);
                tackeDR.Redni_broj = int.Parse(brojTacke);
                tackeDR.Dokument = idDokumenta;

                db.Tacke_Dnevnog_Reda.Add(tackeDR);
                db.SaveChanges();
            }
            return Json("Uploaded " + Request.Files.Count + " files");
        }

    }
}
