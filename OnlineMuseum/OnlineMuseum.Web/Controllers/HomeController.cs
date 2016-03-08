using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using PagedList.Mvc;
using System.Net;

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

        /// <summary>
        /// Index page.
        /// </summary>
        /// <returns>Index view.</returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Back to home page.
        /// </summary>
        /// <returns>Index view.</returns>
        public ActionResult BackToHomePage()
        {
            return RedirectToAction("Index");
        }

        /// <summary>
        /// Back to categories.
        /// </summary>
        /// <returns>Categories view.</returns>
        public ActionResult BackToCategories()
        {
            return RedirectToAction("MuseumCategories");
        }

        /// <summary>
        /// Museum categories.
        /// </summary>
        /// <returns>All categories.</returns>
        public async Task<ActionResult> MuseumCategories()
        {            
            return View(await categoryService.GetAllCategoriesAsync());
        }

        /// <summary>
        /// New vehicle.
        /// </summary>
        /// <returns>Vehicle model.</returns>
        public async Task<ActionResult> NewVehicle()
        {
            ViewBag.VehicleCategories = new SelectList(await categoryService.GetAllCategoriesAsync(), "Id", "Name");
            ViewBag.MakerCategories = new SelectList(await makerService.GetAllMakersAsync(), "Id", "Name");

            return View(new VehicleModelPoco());
        }

        /// <summary>
        /// New vehicle.
        /// </summary>
        /// <param name="vehicle">Vehicle.</param>
        /// <returns>Index view if model state is valid.</returns>
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

        /// <summary>
        /// Get vehicles action.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <param name="makerId">Maker id.</param>
        /// <param name="findVehicle">Find vehicle.</param>
        /// <param name="pageNumber">Page number.</param>
        /// <param name="pageSize">Page size.</param>
        /// <param name="sortOrderByMaker">Sort order by maker.</param>
        /// <returns>Vehicles.</returns>
        public async Task<ActionResult> GetVehicles(Guid id, Guid? makerId, string findVehicle, int pageNumber = 1, int pageSize = 12, string sortOrderByMaker= "VehicleMaker.Name")
        {       
            try
            {
                PagingParameters paging = new PagingParameters(pageNumber, pageSize);
                VehicleFilter filtering = new VehicleFilter(id, findVehicle, makerId);
                SortingParameters sortingFilter = new SortingParameters(sortOrderByMaker);

                ViewBag.SortMaker = sortOrderByMaker == "VehicleMaker.Name" ? "VehicleMaker.Name desc" : "VehicleMaker.Name";

                ViewBag.Makers = new SelectList(await makerService.GetAllMakersAsync(), "Id", "Name");
                ViewBag.CurrentSort = sortOrderByMaker;
                ViewBag.CurrentSearch = findVehicle;
                ViewBag.CurrentMaker = makerId;

                return View(await vehicleService.GetVehiclesAsync(paging, filtering, sortingFilter));
            }
            catch
            {
                return new HttpNotFoundResult("There are no vehicles");
            }
       
        }   

        /// <summary>
        /// More details about the vehicle.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>One vehicle.</returns>
        public async Task<ActionResult> MoreDetails(Guid id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var details = await vehicleService.GetOneVehicleAsync(id);

            if (details == null)
            {
                return HttpNotFound();
            }

            return View(details);
        }

        /// <summary>
        /// Deletes vehicle.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>Get vehicles page.</returns>
        public async Task<ActionResult> DeleteVehicle(Guid id)
        {
            var vehicle =  await vehicleService.GetOneVehicleAsync(id);
            var categoryId = vehicle.VehicleCategoryId;

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else if (vehicle == null)
            {
                return HttpNotFound();
            }

            await vehicleService.DeleteVehicleAsync(id);

            return RedirectToAction("GetVehicles", new { id = categoryId });
        }
    }
}