using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
//KOD YAZARKEN DÜŞÜN!!!!
namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        Car GetById(int id);
        Car GetBrandById(int brandId);
        Car GetColorById(int colorId);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);

        List<CarDetailDto> GetCarDetails();
    }
}
