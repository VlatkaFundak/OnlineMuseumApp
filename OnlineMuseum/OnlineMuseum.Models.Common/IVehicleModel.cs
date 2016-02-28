using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMuseum.Models.Common
{
    /// <summary>
    /// Vehicle model interface.
    /// </summary>
    public interface IVehicleModel
    {
        #region Properties

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        Guid Id { get; set; }

        /// <summary>
        /// Gets or sets model of the vehicle.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Gets or sets abreviaton.
        /// </summary>
        string Abrv { get; set; }

        /// <summary>
        /// Gets or sets year of production.
        /// </summary>
        int YearOfProduction { get; set; }

        /// <summary>
        /// Gets or sets image url.
        /// </summary>
        string ImageUrl { get; set; }

        /// <summary>
        /// Gest or sets description.
        /// </summary>
        string Description { get; set; }

        /// <summary>
        /// Gest or sets fun facts.
        /// </summary>
        string FunFacts { get; set; }

        /// <summary>
        /// Gets or sets time.
        /// </summary>
        Guid TimeCategoryId { get; set; }

        /// <summary>
        /// Gets or sets time.
        /// </summary>
        ITimeCategory TimeCategory { get; set; }

        /// <summary>
        /// Gets or sets vehicle type.
        /// </summary>
        Guid VehicleCategoryId { get; set; }

        /// <summary>
        /// Gets or sets vehicle type.
        /// </summary>
        IVehicleCategory VehicleCategory { get; set; }

        /// <summary>
        /// Gets or sets maker of the vehicle.
        /// </summary>
        Guid VehicleMakerId { get; set; }

        /// <summary>
        /// Gets or sets maker of the vehicle.
        /// </summary>
        IVehicleMaker VehicleMaker { get; set; }

       #endregion
    }
}
