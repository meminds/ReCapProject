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
    public class EfColorDal : IColorDal
    {
        public void Add(Color entity)
        {
            using (CarDbContext carDbContext = new CarDbContext())
            {
                var addedEntity = carDbContext.Entry(entity);
                addedEntity.State = EntityState.Added;
                carDbContext.SaveChanges();
            }
        }

        public void Delete(Color entity)
        {
            using (CarDbContext carDbContext = new CarDbContext())
            {
                var deletedEntity = carDbContext.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                carDbContext.SaveChanges();
            }
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            using (CarDbContext carDbContext = new CarDbContext())
            {
                return carDbContext.Set<Color>().SingleOrDefault(filter);
            }
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            using (CarDbContext carDbContext = new CarDbContext())
            {
                return filter == null
                    ? carDbContext.Set<Color>().ToList()
                    : carDbContext.Set<Color>().Where(filter).ToList();
            }
        }

        public void Update(Color entity)
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
