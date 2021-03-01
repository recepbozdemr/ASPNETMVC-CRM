using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HERASOFTCRM.Models.Siniflar;
namespace HERASOFTCRM.Controllers
{

   
    public class KontakController : Controller
    {
        Context baglanti = new Context();
        // GET: Kontak
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult KontakListe()
        {

            return View();


        }
    }
}