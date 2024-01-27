

using MyWebSite.Models.Siniflar;
using System.Linq;
using System.Web.Mvc;

namespace MyWebSite.Controllers
{
	public class AnaSayfaController : Controller
    {
        // GET: AnaSayfa
        Context c = new Context();  
        public ActionResult Index()
        {
            var deger = c.AnaSayfas.ToList();
            return View(deger);
        }

        public PartialViewResult ikonlar()
        {
            var deger = c.İkonlars.ToList();
            return PartialView(deger);
        }
    }
}