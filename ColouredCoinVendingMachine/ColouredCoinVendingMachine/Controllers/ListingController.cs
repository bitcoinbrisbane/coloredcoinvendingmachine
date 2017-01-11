using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ColouredCoinVendingMachine.Controllers
{
    public class ListingController : Controller
    {
        public Repository.IRepository<Models.Listing> ListingRepository { get; set; }

        public ListingController()
        {
            String dbPath = System.Web.Hosting.HostingEnvironment.MapPath("~/App_Data/") + "cc.db";
            this.ListingRepository = new Repository.LightDB(dbPath);
        }

        public ActionResult Index()
        {
            IEnumerable<Models.Listing> listings = ListingRepository.All;
            return View(listings);
        }

        // GET: Listing
        public async Task<ActionResult> Create(String id)
        {
            if (String.IsNullOrEmpty(id))
            {
                id = "colu";
            }

            Models.Listing listing = new Models.Listing();

            if (id == "colu")
            {
                Clients.IAddressClient client = Factory.GetAddressClient(id);
                listing.AssetAddress = await client.GetAddressAsync();
            }

            return View(listing);
        }

        [HttpPost]
        public async Task<ActionResult> Create(Models.Listing model)
        {
            ListingRepository.Add(model);
            return RedirectToAction("Index");
        }

        public async Task<ActionResult> Purchase(String id)
        {
            Clients.IAddressClient client = Factory.GetAddressClient("colu");

            //Models.Listing listing = ListingRepository.FindById(id);
            Models.OrderViewModel order = new Models.OrderViewModel();

            order.PaymentAddress = await client.GetAddressAsync();

            return View(order);
        }
    }
}