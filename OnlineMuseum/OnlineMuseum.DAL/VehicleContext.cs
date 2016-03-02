using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using OnlineMuseum.Models;

namespace OnlineMuseum.DAL
{
    public class VehicleContext: DbContext
    {
        public VehicleContext()
            : base("OnlineMuseumDb")
        {
            Database.SetInitializer<VehicleContext>(new VehicleDbInitializer());
        }

        public virtual DbSet<VehicleModel> VehicleModels { get; set; }

        public virtual DbSet<VehicleMaker> VehicleMakers { get; set; }

        public virtual DbSet<VehicleCategory> VehicleCategories { get; set; }

        //public virtual DbSet<TimeCategory> TimeCategories { get; set; }
    }
}
