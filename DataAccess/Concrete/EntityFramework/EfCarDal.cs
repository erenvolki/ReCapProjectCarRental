using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace DataAccess.Concrete.Entityframework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarDataContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarDataContext context = new CarDataContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             join col in context.Colors
                             on c.ColorId equals col.Id
                             select new CarDetailDto
                             {
                                 Id = c.Id,
                                 Name = c.Name,
                                 BrandName = b.Name,
                                 ColorName = col.Name,
                                 ModelYear = c.ModelYear,
                                 DailyPrice = c.DailyPrice,
                                 Description = c.Description

                             };
                return result.ToList();
                            

            }
        }
    }
}
