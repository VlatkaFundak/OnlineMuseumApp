using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using OnlineMuseum.Models;

namespace OnlineMuseum.DAL
{
    public class VehicleDbInitializer: DropCreateDatabaseAlways<VehicleContext>
    {
        protected override void Seed(VehicleContext context)
        {
            var Fiat = new VehicleMaker()
            {
                Id = Guid.NewGuid(),
                Name = "Fiat",
                Abrv = "F",
            };
            context.VehicleMakers.Add(Fiat);

            var Opel = new VehicleMaker()
            {
                Id = Guid.NewGuid(),
                Name = "Opel",
                Abrv = "O"
            };
            context.VehicleMakers.Add(Opel);

            var Comeng = new VehicleMaker()
            {
                Id = Guid.NewGuid(),
                Name = "Comeng",
                Abrv = "C"
            };
            context.VehicleMakers.Add(Comeng);

            var Aurora = new VehicleMaker()
            {
                Id = Guid.NewGuid(),
                Name = "Aurora",
                Abrv = "A"
            };
            context.VehicleMakers.Add(Aurora);


            var Train = new VehicleCategory()
            {
                Id = Guid.NewGuid(),
                Name = "Train",
                Abrv = "Tr",
                ImageUrl = ""
            };
            context.VehicleCategories.Add(Train);

            var Auto = new VehicleCategory()
            {
                Id = Guid.NewGuid(),
                Name = "Car",
                Abrv = "Cr",
                ImageUrl = ""
            };
            context.VehicleCategories.Add(Auto);

            var Past = new TimeCategory()
            {
                Id = Guid.NewGuid(),
                Name = "Past",
                Abrv = "Pa"
            };
            context.TimeCategories.Add(Past);

            var Car1 = new VehicleModel()
            {
                Id = Guid.NewGuid(),
                Name = "Punto called Mecava",
                Abrv = "Maco",
                YearOfProduction = 2016,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam sit amet lobortis sapie",
                FunFacts = "A car called Mecava has been through enough trouble, distance, hills but the fastination stays in the fact that it still starts people!",
                TimeCategoryId = Past.Id,
                VehicleCategoryId = Auto.Id,
                VehicleMakerId = Opel.Id,
                ImageUrl = "http://i151.photobucket.com/albums/s131/sid23456/asd008-1.jpg"
            };

            context.VehicleModels.Add(Car1);

            base.Seed(context);
        }
    }
}
