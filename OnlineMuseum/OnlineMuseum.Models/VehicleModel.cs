using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineMuseum.Models.Common;
using System.ComponentModel.DataAnnotations;

namespace OnlineMuseum.Models
{
    /// <summary>
    /// Vehicle model class.
    /// </summary>
    public class VehicleModel: IVehicleModel
    {
        #region Properties

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets model of the vehicle.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets abreviaton.
        /// </summary>
        public string Abrv { get; set; }

        /// <summary>
        /// Gets or sets year of production.
        /// </summary>
        public int YearOfProduction { get; set; }

        /// <summary>
        /// Gets or sets image url.
        /// </summary>
        public string ImageUrl { get; set; }

        /// <summary>
        /// Gest or sets description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gest or sets fun facts.
        /// </summary>
        public string FunFacts { get; set; }

        /// <summary>
        /// Gets or sets time.
        /// </summary>
        public Guid TimeCategoryId { get; set; }

        /// <summary>
        /// Gets or sets vehicle type.
        /// </summary>
        public Guid VehicleCategoryId { get; set; }

        /// <summary>
        /// Gets or sets maker of the vehicle.
        /// </summary>
        public Guid VehicleMakerId { get; set; }

        /// <summary>
        /// Gets or sets time.
        /// </summary>
        public virtual ITimeCategory TimeCategory { get; set; }

        /// <summary>
        /// Gets or sets vehicle type.
        /// </summary>
        public virtual IVehicleCategory VehicleCategory { get; set; }

        /// <summary>
        /// Gets or sets maker of the vehicle.
        /// </summary>
        public virtual IVehicleMaker VehicleMaker { get; set; }

        #endregion

    }
}
