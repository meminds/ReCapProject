using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;
        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car {CarId = 1, BrandId = 1, ColorId = 1, ModelYear = 2020, DailyPrice = 1000, Description = "Fastest"},
                new Car {CarId = 2, BrandId = 2, ColorId = 1, ModelYear = 2021, DailyPrice = 1500, Description = "Safest"},
                new Car {CarId = 3, BrandId = 2, ColorId = 1, ModelYear = 2022, DailyPrice = 2000, Description = "Cheapest"},
                new Car {CarId = 4, BrandId = 2, ColorId = 2, ModelYear = 2019, DailyPrice = 750, Description = "Strongest"}
            };
        }

        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _car.FirstOrDefault(item => item.CarId == car.CarId);
            _car.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetById(int brandId)
        {

            return _car.Where(item => item.BrandId == brandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(item => item.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
