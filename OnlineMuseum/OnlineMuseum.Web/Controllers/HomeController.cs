using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineMuseum.DAL;
using OnlineMuseum.Repository;
using System.Threading.Tasks;

namespace OnlineMuseum.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
        //    VehicleDbInitializer vehicle = new VehicleDbInitializer();
        //    VehicleContext context = new VehicleContext();

        //    vehicle.InitializeDatabase(context);

            VehicleRepository VehicleRepository = new VehicleRepository();



            return View();
        }

    }
}