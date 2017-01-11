using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ColouredCoinVendingMachine.Controllers
{
    public class HomeController : Controller
    {
        public Repository.IRepository<Models.Listing> ListingRepository { get; set; }

        public HomeController()
        {
            String dbPath = System.Web.Hosting.HostingEnvironment.MapPath("~/App_Data/") + "cc.db";
            this.ListingRepository = new Repository.LightDB(dbPath);
        }

        [OutputCache(Duration = 10)]
        public ActionResult Index()
        {
            IEnumerable<Models.Listing> listings = this.ListingRepository.All.Take(5);
            Models.HomeViewModel viewModel = new Models.HomeViewModel(listings);

            return View(viewModel);
        }

        public ActionResult Home()
        {
            return View();
        }
    }
}