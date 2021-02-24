using System.Linq.Expressions;
using Core.CrossCuttingConcerns.Validation;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using FluentValidation;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Business.Constants;
using Entities.DTOs;
using System.Timers;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

       [ValidationAspect(typeof(RentalValidator))]
        public IResult Add(Rental rental)
        {
            var result = _rentalDal.Get(r => r.Id == rental.Id && r.ReturnDate == null);
            if (result != null)
            {
                return new ErrorResult(Messages.Carbusy);
            }
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.RentalAdded);
        }

        public IDataResult<List<Rental>> AvailableCar()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(p => p.ReturnDate != null));
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IResult Deliver(int rentalId)
        {
            var result = _rentalDal.Get(c => c.Id == rentalId);
            result.ReturnDate = DateTime.Now.Date;
            Update(result);
            return new SuccessResult(Messages.RentalDelivered);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(c => c.Id == id));
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetails()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails());
        }

              
        [ValidationAspect(typeof(RentalValidator))]
        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.RentalUptated);
        }
    }
}
