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

        public ActionResult RegistererList(Registerer register)
        {
            return View();
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
                    return View();
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