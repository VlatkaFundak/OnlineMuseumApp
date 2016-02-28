using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMuseum.Models.Common
{
    /// <summary>
    /// Vehicle category interface.
    /// </summary>
    public interface IVehicleCategory
    {
        #region Properties

        /// <summary>
        /// Gest or sets Id.
        /// </summary>
        Guid Id { get; set; }

        /// <summary>
        /// Gest or sets name.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Gets or sets abreviaton.
        /// </summary>
        string Abrv { get; set; }

        /// <summary>
        /// Gets or sets image url.
        /// </summary>
        string ImageUrl { get; set; }

        #endregion
    }
}
