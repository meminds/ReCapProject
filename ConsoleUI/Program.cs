using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine("Car ID: " + item.CarId + "   Car Price: " + item.DailyPrice + "   Car Description: " + item.Description);
            }
            // foreach (var item in carManager.GetById(1))
        }
    }
}
