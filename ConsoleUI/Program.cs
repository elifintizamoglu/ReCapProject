using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            carManager.Add(new Car
            {
                Id = 6,
                BrandId = 6,
                ColorId = 3,
                ModelYear = 2006,
                DailyPrice = 600,
                Description = "Mercedes"
            });

            Car car1 = new Car { Id = 7, BrandId = 1, ColorId = 4, ModelYear = 2007, DailyPrice = 700, Description = "Audi" };
            carManager.Add(car1);
         
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
            Console.WriteLine("\n");


            foreach (var c in carManager.GetById(4))
            {
                Console.WriteLine(c.Description);
            }

            carManager.Delete(car1);
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}

