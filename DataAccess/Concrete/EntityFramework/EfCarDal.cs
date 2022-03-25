using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (CarDbContext carDbContext = new CarDbContext())
            {
                var addedEntity = carDbContext.Entry(entity);
                addedEntity.State = EntityState.Added;
                carDbContext.SaveChanges();
            }
        }

        public void Delete(Car entity)
        {
            using (CarDbContext carDbContext = new CarDbContext())
            {
                var deletedEntity = carDbContext.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                carDbContext.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (CarDbContext carDbContext = new CarDbContext())
            {
                return carDbContext.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (CarDbContext carDbContext = new CarDbContext())
            {
                return filter == null
                    ? carDbContext.Set<Car>().ToList()
                    : carDbContext.Set<Car>().Where(filter).ToList();
            }
        }

        public void Update(Car entity)
        {
            using (CarDbContext carDbContext = new CarDbContext())
            {
                var updatedEntity = carDbContext.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                carDbContext.SaveChanges();
            }
        }
    }
}
