using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMuseum.Common
{
    /// <summary>
    /// Vehicle filter class.
    /// </summary>
    public class VehicleFilter : IVehicleFilter
    {
        #region Constructor

        /// <summary>
        /// Vehicle filter constructor.
        /// </summary>
        /// <param name="categoryId">Category id.</param>
        /// <param name="findVehicle">Find vehicle.</param>
        /// <param name="makerId">Maker id.</param>
        public VehicleFilter(Guid categoryId, string findVehicle, Guid? makerId)
        {
            this.CategoryId = categoryId;
            this.FindVehicle = findVehicle;
            this.MakerId = makerId.HasValue ? makerId.Value : Guid.Empty;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets category id.
        /// </summary>
        public Guid? CategoryId { get; set; }

        /// <summary>
        /// Gets or sets find vehicle.
        /// </summary>
        public string FindVehicle { get; set; }

        /// <summary>
        /// Gets or sets maker id.
        /// </summary>
        public Guid? MakerId { get; set; }

        #endregion
    }
}
