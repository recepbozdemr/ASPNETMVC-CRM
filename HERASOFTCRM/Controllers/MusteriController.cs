using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HERASOFTCRM.Models.Siniflar;
namespace HERASOFTCRM.Controllers
{


    public class MusteriController : Controller
    {
        Context baglanti = new Context();
        // GET: Musteri
        public ActionResult Index()
        {
            var musteriler = baglanti.Musteris.ToList();
            return View(musteriler);
        }

        [HttpGet]
        public ActionResult MusteriEkle()
        {
            List<SelectListItem> deger1 = (from x in baglanti.Kategoris.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.KategoriAd,
                                               Value = x.KategoriID.ToString()
                                           }).ToList();
            ViewBag.dgr1 = deger1;  // Değer Taşımak için kullanıyorum
            return View();

        }

        [HttpPost]
        public ActionResult MusteriEkle(Musteri k)
        {
            baglanti.Musteris.Add(k);
            baglanti.SaveChanges();
            return RedirectToAction("Index");
        }



        public ActionResult MusteriSil(int id)
        {
            var kate = baglanti.Musteris.Find(id);   //Bağlantı içindeki Kategorisde idyi bul kate'ye ata
            baglanti.Musteris.Remove(kate);  // kateyi sildiğimde çıkar
            baglanti.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult MusteriGetir(int id)

        {
            List<SelectListItem> deger1 = (from x in baglanti.Kategoris.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.KategoriAd,
                                               Value = x.KategoriID.ToString()
                                           }).ToList();
            ViewBag.dgr1 = deger1;  // Değer Taşımak için kullanıyorum
            var musterideger = baglanti.Musteris.Find(id);
            return View("MusteriGetir", musterideger);


        }
        public ActionResult MusteriGuncelle(Musteri p)
        {

            var urn = baglanti.Musteris.Find(p.musteriID);
            urn.musteriUnvan = p.musteriUnvan;
            urn.musteriTelefon = p.musteriTelefon;
            urn.KategoriID = p.KategoriID;
            urn.musteriVergiDairesi = p.musteriVergiDairesi;
            urn.musteriVergino = p.musteriVergino;
            urn.webAdres = p.webAdres;
            urn.musteriNot = p.musteriNot;
            urn.musteriSozlesmeTutar = p.musteriSozlesmeTutar;
            urn.musteriMail = p.musteriMail;
            urn.musteriIlgili = p.musteriIlgili;
            urn.musteriIlgilino = p.musteriIlgilino;
            urn.musteriIl = p.musteriIl;
            urn.musteriIlce = p.musteriIlce;
            baglanti.SaveChanges();
            return RedirectToAction("Index");

        }

    }
}