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
            var rand = new Random();

            for (int i = 0; i < 50; ++i)
            {
                cars.Add(new Car()
                {
                    Mileage = rand.Next(1000, 1000000),
                    Brand = $"BMW {rand.Next(12, 98)}",
                    Year = rand.Next(1970, 2016),
                    Price = rand.Next(100000, 10000000)
                }
                    );
            }

            context.Cars.AddRange(cars);

            base.InitializeDatabase(context);
        }
    }
}