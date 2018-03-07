using joesGolfSite.Models;
using Newtonsoft.Json;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace joesGolfSite.Controllers
{
    public class HomeController : Controller
    {
        public GolfSiteDbContext dbgolf = new GolfSiteDbContext();
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        public ActionResult Teams()
        {
            var registerers = dbgolf.Registerers;
            return View("RegistererList", registerers);
        }

        public ActionResult AdminView()
        {
            var registerers = dbgolf.Registerers;
            return View("AdminView", registerers);
        }

        [HttpPost]
        public ActionResult LoadPage(string AdminCode)
        {
            if (AdminCode == "48DD25BF-84E6-4D73-AAFD-BEBC6D9DD729")
            {
                var registerers = dbgolf.Registerers;
                return View("RegistererList", registerers);
            }
            return View("Teams");

        }
      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Registerer register)
        {
            var db = new GolfSiteDbContext();
            try
            {
                if (ModelState.IsValid)
                {
                    db.Registerers.Add(register);
                    db.SaveChanges();
                    return View("Index");
                }
            }
            catch (RetryLimitExceededException)
            {
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
            }
            return View(register);
        }
    }
}