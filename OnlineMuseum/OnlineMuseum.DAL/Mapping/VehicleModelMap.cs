using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OnlineMuseum.DAL.Entities;

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;  

namespace OnlineMuseum.DAL.Mapping
{
    public class VehicleModelMap: EntityTypeConfiguration<VehicleModel>
    {
        public VehicleModelMap()
        {
            this.HasKey(t => t.Id);

            this.Property(t => t.Id).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(t => t.Abrv);
            this.Property(t => t.Name).IsRequired();
            this.Property(t => t.YearOfProduction).IsRequired();
            this.Property(t => t.Description).IsRequired();
            this.Property(t => t.FunFacts).IsRequired();
            this.Property(t => t.ImageUrlOfThePast).IsRequired();
            this.Property(t => t.ImageUrlOfThePresent).IsRequired();
            this.Property(t => t.VehicleCategoryId).IsRequired();
            this.Property(t => t.VehicleMakerId).IsRequired();

            this.ToTable("VehicleModels");

            this.HasRequired(t => t.VehicleMaker).WithMany(c => c.VeehicleModels)
                .HasForeignKey(t => t.VehicleMakerId).WillCascadeOnDelete(false);

            this.HasRequired(t => t.VehicleCategory).WithMany(c => c.VehicleModels)
                .HasForeignKey(t => t.VehicleCategoryId).WillCascadeOnDelete(false);
        }
        
    }
}
