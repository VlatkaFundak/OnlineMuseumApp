using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

using OnlineMuseum.Models.Common;

namespace OnlineMuseum.Models
{
    /// <summary>
    /// Vehicle category class.
    /// </summary>
    public class VehicleCategoryPoco : IVehicleCategory
    {
        #region Properties

        /// <summary>
        /// Gest or sets Id.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gest or sets name.
        /// </summary>
        [Required(ErrorMessage = "Enter name of the category")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets abreviaton.
        /// </summary>
        public string Abrv { get; set; }

        /// <summary>
        /// Gets or sets image url.
        /// </summary>
        [Required(ErrorMessage = "Enter image url of the category.")]
        public string ImageUrl { get; set; }

        #endregion
    }
}
