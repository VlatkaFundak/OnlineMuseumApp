using System;
namespace OnlineMuseum.Common
{
    public interface IVehicleFilter
    {
        Guid? CategoryId { get; set; }

        string FindVehicle { get; set; }

        Guid? MakerId { get; set; }

    }
}
