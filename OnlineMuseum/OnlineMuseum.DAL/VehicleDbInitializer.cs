using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using OnlineMuseum.Models;
using OnlineMuseum.DAL.Entities;

namespace OnlineMuseum.DAL
{
    public class VehicleDbInitializer: DropCreateDatabaseIfModelChanges<VehicleContext>
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


            var Trains = new VehicleCategory()
            {
                Id = Guid.NewGuid(),
                Name = "Trains",
                Abrv = "Tr",
                ImageUrl = ""
            };
            context.VehicleCategories.Add(Trains);

            var Cars = new VehicleCategory()
            {
                Id = Guid.NewGuid(),
                Name = "Cars",
                Abrv = "Ca",
                ImageUrl = ""
            };
            context.VehicleCategories.Add(Cars);

            //var Past = new TimeCategory()
            //{
            //    Id = Guid.NewGuid(),
            //    Name = "Past",
            //    Abrv = "Pa"
            //};
            //context.TimeCategories.Add(Past);

            for (int i = 0; i < 15; i++)
            {
                var Car1 = new VehicleModel()
                {
                    Id = Guid.NewGuid(),
                    Name = "Punto",
                    Abrv = "Maco  called Mecava",
                    YearOfProduction = 2016,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam sit amet lobortis sapie",
                    FunFacts = "A car called Mecava has been through enough trouble, distance, hills but the fastination stays in the fact that it still starts people!",
                    //TimeCategoryId = Past.Id,
                    VehicleCategoryId = Cars.Id,
                    VehicleMakerId = Opel.Id,
                    ImageUrlOfThePast = "http://i151.photobucket.com/albums/s131/sid23456/asd008-1.jpg",
                    ImageUrlOfThePresent = "http://i151.photobucket.com/albums/s131/sid23456/asd008-1.jpg"
                };

                context.VehicleModels.Add(Car1);
            }


            base.Seed(context);
        }
    }
}
