using MyWebSite.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebSite.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var deger = c.AnaSayfas.ToList();
            return View(deger);
        }

        public ActionResult AnaSayfaGetir(int id) 
        {
            var ag = c.AnaSayfas.Find(id);
            return View("AnaSayfaGetir",ag);
        }
        public ActionResult AnaSayfaGuncelle(AnaSayfa x)
        {
            var ag = c.AnaSayfas.Find(x.Id);
            ag.İsim = x.İsim;
            ag.İletisim = x.İletisim;
            ag.Aciklama = x.Aciklama;
            ag.Unvan = x.Unvan;
            ag.Profil = x.Profil;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult İkonListesi()
        {
            var deger = c.İkonlars.ToList();
            return View(deger);
        }

        [HttpGet]
        public ActionResult YeniIkon()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniIkon(İkonlar p)
        {
            c.İkonlars.Add(p);
            c.SaveChanges();
            return RedirectToAction("İkonListesi");
        }

        public ActionResult İkonGetir(int id)
        {
            var ig = c.İkonlars.Find(id);
            return View("İkonGetir", ig);
        }

        public ActionResult İkonGuncelle(İkonlar x)
        {
            var ig = c.İkonlars.Find(x.İd);
            ig.İkon = x.İkon;
            ig.Link = x.Link;
            ig.Renk = x.Renk;
            c.SaveChanges();    
            return RedirectToAction("İkonListesi");

        }

        public ActionResult İkonSil(int id)
        {
            var sil = c.İkonlars.Find(id);
            c.İkonlars.Remove(sil);
            c.SaveChanges();
            return RedirectToAction("İkonListesi");
        }


    }
}