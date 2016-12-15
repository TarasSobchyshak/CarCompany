using CarCompany.Entites;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace CarCompany.DataContext
{

    public class DatabaseInitializer : CreateDatabaseIfNotExists<DataContext>
    {
        public override void InitializeDatabase(DataContext context)
        {
            var cars = new List<Car>();

            for (int i = 0; i < 50; ++i)
            {
                cars.Add(new Car()
                {
                    Mileage = new Random().Next(1000, 1000000),
                    Brand = $"BMW {new Random().Next(12, 98)}",
                    Year = new Random().Next(1970, 2016),
                    Price = new Random().Next(100000, 10000000)
                }
                    );
            }

            context.Cars.AddRange(cars);

            base.InitializeDatabase(context);
        }
    }
}