using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using OnlineMuseum.Models;
using OnlineMuseum.DAL.Entities;
using OnlineMuseum.DAL.Mapping;

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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new VehicleCategoryMap());
            modelBuilder.Configurations.Add(new VehicleMakerMap());
            modelBuilder.Configurations.Add(new VehicleModelMap());
            
            base.OnModelCreating(modelBuilder);
        }


    }
}
