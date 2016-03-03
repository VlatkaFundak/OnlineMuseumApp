using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMuseum.DAL.Entities
{
    public class VehicleCategory
    {
        /// <summary>
        /// Gest or sets Id.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gest or sets name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets abreviaton.
        /// </summary>
        public string Abrv { get; set; }

        /// <summary>
        /// Gets or sets image url.
        /// </summary>
        //[Required(ErrorMessage="Enter image url of the category.")]
        public string ImageUrl { get; set; }

        public ICollection<VehicleModel> VehicleModels { get; set; }
    }
}
