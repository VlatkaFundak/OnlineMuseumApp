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
    public class VehicleModelPoco: IVehicleModel
    {
        #region Properties

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets model of the vehicle.
        /// </summary>
        [Required(ErrorMessage = "Enter name of the vehicle")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets abreviaton.
        /// </summary>
        public string Abrv { get; set; }

        /// <summary>
        /// Gets or sets year of production.
        /// </summary>
        [Required(ErrorMessage = "Enter year of the vehicle")]
        public int YearOfProduction { get; set; }

        /// <summary>
        /// Gets or sets image url of the past.
        /// </summary>
        [Required(ErrorMessage = "Enter image of the past")]
        public string ImageUrlOfThePast { get; set; }

        /// <summary>
        /// Gets or sets image url of the present.
        /// </summary>
        [Required(ErrorMessage = "Enter iamte of the present")]
        public string ImageUrlOfThePresent { get; set; }

        /// <summary>
        /// Gest or sets description.
        /// </summary>
        [Required(ErrorMessage = "Enter description of the vehicle")]
        public string Description { get; set; }

        /// <summary>
        /// Gest or sets fun facts.
        /// </summary>
        [Required(ErrorMessage = "Enter fun facts of the vehicle")]
        public string FunFacts { get; set; }

        /// <summary>
        /// Gets or sets vehicle type.
        /// </summary>
        public Guid VehicleCategoryId { get; set; }

        /// <summary>
        /// Gets or sets maker of the vehicle.
        /// </summary>
        public Guid VehicleMakerId { get; set; }

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
