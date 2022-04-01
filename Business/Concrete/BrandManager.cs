using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IDataResult<List<Brand>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Brand>>(Messages.MaintenanceTime);
            }
            //InMemoryProductDal ınMemoryProductDal = new InMemoryProductDal();  // InMemory veritabanımız. EntityFramework'e döndürdüğümüzde bu kodları manuel olarak değişmek zorunda kalırız.
            // Bu yüzden yukarıda yazdığımız cons.'ı kullanırız.
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(), Messages.CarListed);
        }

        public IDataResult<Brand> GetById(int brandId)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(c => c.BrandId == brandId));
        }
    }
}
