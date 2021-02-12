using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {

        List<Car> _cars;
        private object brandId;

        public InMemoryCarDal()
        {
            _cars = new List<Car> {
             new Car{ Id=1, BrandId = 2, ColorId = 10, ModelYear= 2019, DailyPrice= 20000, Description="Mercedes"},
             new Car{ Id=2, BrandId = 4, ColorId = 20, ModelYear= 2020, DailyPrice= 30000, Description="Audi"},
             new Car{ Id=3, BrandId = 6, ColorId = 30, ModelYear= 2021, DailyPrice= 40000, Description="BMW"},

            };

        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);

            _cars.Remove(carToDelete);
        }


        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.Brand = car.BrandId;
            carToUpdate.Color = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

        }
    }
}
