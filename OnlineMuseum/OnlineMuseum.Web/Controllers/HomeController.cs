using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;

using OnlineMuseum.Models.Common;
using OnlineMuseum.Services.Common;
using OnlineMuseum.Services;

namespace OnlineMuseum.Web.Controllers
{
    public class HomeController : Controller
    {
        private IVehicleService vehicleService;

        public HomeController()
        {
             vehicleService = new VehicleService();
        }
                
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Back()
        {
            return RedirectToAction("Index");
        }

        public ActionResult BackToCategories()
        {
            return RedirectToAction("MuseumCategories");
        }

        public async Task<ActionResult> MuseumCategories()
        {
            return View(await vehicleService.GetAllCategoriesAsync());
        }

        [HttpGet]
        public ActionResult NewVehicle()
        {
            return View();
        }

        public ActionResult NewCategory()
        {
            return View();
        }

        public async Task<ActionResult> DetailsOfTheVehicle(Guid id)
        {
            return View(await vehicleService.GetAllVehiclesInCategory(id));
        }


    }
}