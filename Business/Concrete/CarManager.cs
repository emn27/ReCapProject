using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
//KOD YAZARKEN DÜŞÜN!!!!
namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.Name.Length >= 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
                System.Console.WriteLine("car eklendi");
            }
            else
            {
                System.Console.WriteLine("Araba ismi minimum 2 karakter ve araba günlük fiyatı" +
                    " 0'dan büyük olmalıdır!");
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public Car GetBrandById(int brandId)
        {
            return _carDal.Get(c => c.BrandId == brandId);
        }

        public Car GetById(int id)
        {
            return _carDal.Get(c => c.Id == id);
        }

        public Car GetColorById(int colorId)
        {
            return _carDal.Get(c=> c.ColorId == colorId);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
