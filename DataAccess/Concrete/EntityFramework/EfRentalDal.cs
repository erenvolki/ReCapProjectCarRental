using System.Linq;
using System.Linq.Expressions;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarDataContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (CarDataContext context=new CarDataContext())
            {
                var result = from c in context.Cars
                             join r in context.Rentals
                             on c.Id equals r.Id
                             join cus in context.Customers
                             on r.CustomerId equals cus.UserId
                             join u in context.Users
                             on cus.UserId equals u.Id
                             select new RentalDetailDto
                             {
                                 Id=r.Id,
                                 CarId=c.Id,
                                 CarName=c.Name,
                                 DailyPrice = c.DailyPrice,
                                 CustomerName =cus.CompanyName,
                                 RentDate=r.RentDate,
                                 ReturnDate=r.ReturnDate,
                                 Username=u.FirstName + " " + u.Lastname,
                                

                                 
                                                                  
                             };
                return result.ToList();
                            
            }
        }
    }
}
