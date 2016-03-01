//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data.Entity;

//using OnlineMuseum.DAL;
//using OnlineMuseum.Models.Common;
//using OnlineMuseum.Repository.Common;

//namespace OnlineMuseum.Repository
//{
//    public class TimeRepository: ITimeRepository
//    {
//        #region Fields

//        /// <summary>
//        /// Vehicle context field.
//        /// </summary>
//        private VehicleContext vehicleContext;

//        #endregion

//        #region Constructor

//        /// <summary>
//        /// Time repository constructor.
//        /// </summary>
//        public TimeRepository()
//        {
//            vehicleContext = new VehicleContext();        
//        }

//        #endregion

//        public async Task<IEnumerable<ITimeCategory>> GetAllTimeCategoriesAsync()
//        {
//            return await vehicleContext.TimeCategories.ToListAsync();
//        }

//        public async Task<ITimeCategory> GetOneTimeCategoryAsync(Guid id)
//        {
//            return await vehicleContext.TimeCategories.FindAsync(id);
//        }
//    }
//}
