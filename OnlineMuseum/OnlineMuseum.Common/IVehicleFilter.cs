using System;
namespace OnlineMuseum.Common
{
    public interface IVehicleFilter
    {
        Guid? CategoryId { get; set; }

        string Name { get; set; }

    }
}
