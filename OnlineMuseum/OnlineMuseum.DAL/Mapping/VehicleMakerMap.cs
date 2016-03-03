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
    public class VehicleMakerMap: EntityTypeConfiguration<VehicleMaker>
    {
        public VehicleMakerMap()
        {
            this.HasKey(t => t.Id);

            this.Property(t => t.Id).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(t => t.Abrv);
            this.Property(t => t.Name).IsRequired();
            this.ToTable("VehicleMakers");
        }

    }
}
