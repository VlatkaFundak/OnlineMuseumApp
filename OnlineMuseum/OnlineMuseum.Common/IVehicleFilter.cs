using System;
namespace OnlineMuseum.Common
{
    /// <summary>
    /// Vehicle filter interface.
    /// </summary>
    public interface IVehicleFilter
    {
        /// <summary>
        /// Gets or sets category id.
        /// </summary>
        Guid? CategoryId { get; set; }

        /// <summary>
        /// Gets or sets find vehicle.
        /// </summary>
        string FindVehicle { get; set; }

        /// <summary>
        /// Gets or sets maker id.
        /// </summary>
        Guid? MakerId { get; set; }

    }
}
