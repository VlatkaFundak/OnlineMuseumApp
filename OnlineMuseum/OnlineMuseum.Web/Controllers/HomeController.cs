using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using PagedList.Mvc;

using OnlineMuseum.Common;
using OnlineMuseum.Models;
using OnlineMuseum.Services;
using OnlineMuseum.Models.Common;
using OnlineMuseum.Services.Common;

namespace OnlineMuseum.Web.Controllers
{
    public class HomeController : Controller
    {
        #region Fields

        /// <summary>
        /// Vehicle service field.
        /// </summary>
        private IVehicleService vehicleService;
        private ICategoryService categoryService;
        private IMakerService makerService;

        #endregion

        #region Constructor

        /// <summary>
        /// Home controller constructor.
        /// </summary>
        public HomeController()
        {
             vehicleService = new VehicleService();
             categoryService = new CategoryService();
             makerService = new MakerService();
        }

        #endregion

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BackToHomePage()
        {
            return RedirectToAction("Index");
        }

        public ActionResult BackToCategories()
        {
            return RedirectToAction("MuseumCategories");
        }

        public async Task<ActionResult> MuseumCategories()
        {
            return View(await categoryService.GetAllCategoriesAsync());
        }

        public async Task<ActionResult> NewVehicle()
        {
            ViewBag.VehicleCategories = new SelectList(await categoryService.GetAllCategoriesAsync(), "Id", "Name");
            ViewBag.MakerCategories = new SelectList(await makerService.GetAllMakersAsync(), "Id", "Name");

            return View(new VehicleModelPoco());
        }


        [HttpPost]
        public async Task<ActionResult> NewVehicle(VehicleModelPoco vehicle)
        {
            if (ModelState.IsValid)
            {
                await vehicleService.InsertVehicleAsync(vehicle);
                return RedirectToAction("Index");
            }

            ViewBag.VehicleCategories = new SelectList(await categoryService.GetAllCategoriesAsync(), "Id", "Name");
            ViewBag.MakerCategories = new SelectList(await makerService.GetAllMakersAsync(), "Id", "Name");

            return View();
        }

        /// <summary>
        /// New category.
        /// </summary>
        /// <returns>Vehicle category.</returns>
        public ActionResult NewCategory()
        {
            return View(new VehicleCategoryPoco());
        }
        
        /// <summary>
        /// New category.
        /// </summary>
        /// <param name="category">Category.</param>
        /// <returns>Index page.</returns>
        [HttpPost]
        public async Task<ActionResult> NewCategory( VehicleCategoryPoco category)
        {
            if (ModelState.IsValid)
            {
                await categoryService.InsertCategoryAsync(category);
                return RedirectToAction("Index");
            }

            return View();
        }

        public async Task<ActionResult> GetVehicles(Guid id, Guid? makerId, string findVehicle, int pageNumber = 1, int pageSize = 12, string sortOrderByCategory = "VehicleCategory.Name")
        {            
            PagingParameters paging = new PagingParameters(pageNumber, pageSize);
            VehicleFilter filtering = new VehicleFilter(id, findVehicle, makerId);
            SortingParameters sortingFilter = new SortingParameters(sortOrderByCategory);

            ViewBag.SortCategory = sortOrderByCategory == "VehicleCategory.Name" ? "VehicleCategory.Name desc" : "VehicleCategory.Name";
            ViewBag.Makers = new SelectList(await makerService.GetAllMakersAsync(), "Id", "Name");

            return View(await vehicleService.GetVehiclesAsync(paging, filtering, sortingFilter));            
        }

        /// <summary>
        /// More details about the vehicle.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>One vehicle.</returns>
        public async Task<ActionResult> MoreDetails(Guid id)
        {
            return View(await vehicleService.GetOneVehicleAsync(id));
        }

        public ActionResult DeleteVehicle(Guid id)
        {
            vehicleService.DeleteVehicleAsync(id);

            return RedirectToAction("MuseumCategories");
        }
    }
}