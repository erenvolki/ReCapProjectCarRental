using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICarService
    {
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);
        List<Car> GetAll();
        List<Car> GetCarsByBrandId(int carId);
        List<Car> GetCarsByColorId(int colorId);
        List<CarDetailDto> GetCarDetails();
    }
}
