using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMuseum.DAL.Entities
{
    public class VehicleModel
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
        /// Gets or sets image url of the past.
        /// </summary>
        public string ImageUrlOfThePast { get; set; }

        /// <summary>
        /// Gets or sets image url of the present.
        /// </summary>
        public string ImageUrlOfThePresent { get; set; }

        /// <summary>
        /// Gest or sets description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gest or sets fun facts.
        /// </summary>
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
        public virtual VehicleCategory VehicleCategory { get; set; }

        /// <summary>
        /// Gets or sets maker of the vehicle.
        /// </summary>
        public virtual VehicleMaker VehicleMaker { get; set; }

        #endregion
    }
}
