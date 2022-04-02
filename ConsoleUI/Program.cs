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
            //CarTest();
            //BrandTest();
            //UserAddTest();
            //UserDeleteTest();
            //CustomerAddTest();
            //RantalControllerTest();
        }

        private static void RantalControllerTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            rentalManager.Add(new Rental { CarId = 3, CustomerId = 1, RentDate = new DateTime(2022, 03, 18, 09, 00, 00), ReturnDate = new DateTime(2022, 03, 19, 09, 00, 00) });
            foreach (var item in rentalManager.GetAll().Data)
            {
                Console.WriteLine(item.CustomerId);
            }
        }

        private static void CustomerAddTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(new Customer { UserId = 10, CompanyName = "Inseder" });
        }

        private static void UserDeleteTest()
        {
            User user = new User();
            user.UserId = 16;
            UserManager userManager = new UserManager(new EfUserDal());
            userManager.Delete(user);
            foreach (var item in userManager.GetAll().Data)
            {
                Console.WriteLine(item.UserId + " / " + item.FirstName);
            }
        }

        private static void UserAddTest()
        {
            /*
            User user = new User() { FirstName = "Fuat", LastName = "Demiroğ", Email = "assd@mail", Password = "34343" };
            User user1 = new User() { FirstName = "Derya", LastName = "Asa", Email = "fgdfg@mail", Password = "12343" };
            User user2 = new User() { FirstName = "Naz", LastName = "İlhan", Email = "cvxcvxc@mail", Password = "12343" };
            User user3 = new User() { FirstName = "Sevinç", LastName = "Sahin", Email = "ytytyty@mail", Password = "143" };
            User user4 = new User() { FirstName = "Hikmet", LastName = "Alemdar", Email = "nmnmnm@mail", Password = "12334" };
            */
            UserManager userManager = new UserManager(new EfUserDal());
            /*userManager.Add(user);
            userManager.Add(user1);
            userManager.Add(user2);
            userManager.Add(user3);
            userManager.Add(user4);*/
            foreach (var item in userManager.GetAll().Data)
            {
                Console.WriteLine(item.UserId + " / " + item.FirstName);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var item in brandManager.GetAll().Data)
            {
                Console.WriteLine(item.BrandId + " / " + item.BrandName);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.BrandName + " / " + item.CarId);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
