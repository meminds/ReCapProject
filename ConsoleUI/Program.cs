using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { CarId = 6, BrandId = 2, ColorId = 2, DailyPrice = 1000, Description = "cheapest", ModelYear = 2020});
            foreach (var item in carManager.GetCarsByColorId(2))
            {
                Console.WriteLine("Car ID: " + item.CarId + "   Car Price: " + item.DailyPrice + "   Car Description: " + item.Description);
            }
        }
    }
}
