using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
        public void Add(Car entity)
        {
            _car.Add(entity);
        }

        public void Delete(Car entity)
        {
            Car carToDelete = _car.FirstOrDefault(item => item.CarId == entity.CarId);
            _car.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }
        public void Update(Car entity)
        {
            Car carToUpdate = _car.SingleOrDefault(item => item.CarId == entity.CarId);
            carToUpdate.CarId = entity.CarId;
            carToUpdate.BrandId = entity.BrandId;
            carToUpdate.ColorId = entity.ColorId;
            carToUpdate.ModelYear = entity.ModelYear;
            carToUpdate.DailyPrice = entity.DailyPrice;
            carToUpdate.Description = entity.Description;
        }
    }
}
