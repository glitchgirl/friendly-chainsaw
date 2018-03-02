using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using joesGolfSite.Models;
using System.Data.SqlClient;
using System.Data.Entity.Infrastructure;
using joesGolfSite.Models.ViewModels;
using Newtonsoft.Json;
using System.Web.Script.Serialization;

namespace joesGolfSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult Submit(Registerer data)
        {
            var model = new Registerer();
            model = data;
            Create(data);
            return View("About",model);
        }
        [HttpPost]
        public ActionResult LoadPage(AdminDisplayViewModel model)
        {
            if (model.AdminCode == "RSI")
            {
                Read();
                return View("Results");
            }
            else
            {
                return View("Contact");
            }
        }
        //public ActionResult Results(AdminDisplayResultsViewModel model)
        //{
        //    Read();
        //    return View("Results", model);
        //}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FirstName, LastName, EmailAddress, Phone, TeamName, ShirtSize, Teammembers")]Registerer register)
        {
           var db = new GolfSiteDbContext();
            try
            {
                if (ModelState.IsValid)
                {
                    db.Registerers.Add(register);
                    db.SaveChanges();
                    return  View("About");
                }
            }
            catch (RetryLimitExceededException )
            {
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
            }
            return View("About");
        }
        public ActionResult Read()
        {
            var db = new GolfSiteDbContext();
            var model = new AdminDisplayResultsViewModel();
            try
            {
               // var results = db.Registerers.AsEnumerable().ToString();
                var results =JsonConvert.DeserializeObject(JsonConvert.SerializeObject(db.Registerers.AsEnumerable()));
                var example1Model = new JavaScriptSerializer().Deserialize<Registerer>(JsonConvert.SerializeObject(db.Registerers.AsEnumerable()).ToString());
                model.DisplayResults = "";

                var blah = "no";
                
            }
            catch
            {
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
            }
            return View("Results", model);
        }

    }
}