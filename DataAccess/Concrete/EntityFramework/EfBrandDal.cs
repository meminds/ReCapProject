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
    public class EfBrandDal : IBrandDal
    {
        public void Add(Brand entity)
        {
            using (CarDbContext carDbContext = new CarDbContext())
            {
                var addedEntity = carDbContext.Entry(entity);
                addedEntity.State = EntityState.Added;
                carDbContext.SaveChanges();
            }
        }

        public void Delete(Brand entity)
        {
            using (CarDbContext carDbContext = new CarDbContext())
            {
                var deletedEntity = carDbContext.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                carDbContext.SaveChanges();
            }
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            using (CarDbContext carDbContext = new CarDbContext())
            {
                return carDbContext.Set<Brand>().SingleOrDefault(filter);
            }
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            using (CarDbContext carDbContext = new CarDbContext())
            {
                return filter == null
                    ? carDbContext.Set<Brand>().ToList()
                    : carDbContext.Set<Brand>().Where(filter).ToList();
            }
        }

        public void Update(Brand entity)
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
