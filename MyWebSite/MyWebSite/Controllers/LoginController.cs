using MyWebSite.Models.Siniflar;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;

namespace MyWebSite.Controllers
{
	public class LoginController : Controller
    {
        // GET: Login
        Context c = new Context();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin ad) 
        {
            var bilgiler = c.Admins.FirstOrDefault(x => x.KullaniciAdi == ad.KullaniciAdi && x.Sifre == ad.Sifre);
            if (bilgiler != null) 
            {
                FormsAuthentication.SetAuthCookie(bilgiler.KullaniciAdi, false);
                Session["KullaniciAdi"] = bilgiler.KullaniciAdi.ToString();
                return RedirectToAction("Index", "Admin");
            }
            else 
            { 
                return View(); 
            }
        }

        public ActionResult LogOut() 
        {
			FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Login");

		}
    }
}