using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

//KOD YAZARKEN DÜŞÜN!!!!
namespace ConsoleUI
{
    class Program
    {
        //KOD YAZARKEN DÜŞÜN!!!!
        static void Main(string[] args)
        {
            //CarManager carManager = InMemoryDalGetAllTest();
            //InMemoryGetTest(carManager);

            //KOD YAZARKEN DÜŞÜN!!!!
            //KOD YAZARKEN DÜŞÜN!!!!
            //KOD YAZARKEN DÜŞÜN!!!!


            CarManager carManager = new CarManager(new EfCarDal());
            // BrandManager brandManager = new BrandManager(new EfBrandDal());
            //ColorManager colorManager = new ColorManager(new EfColorDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            //var car = new Car { Id = 3, BrandId = 1, ColorId = 1, ModelYear = 2020, DailyPrice = 0, Description = "yeni araba", Name = "a" };
            //carManager.Add(car);
            //Console.WriteLine("car eklendi");

            //var car = carManager.GetById(3);
            //Console.WriteLine(car.Description);

            //var car = carManager.GetBrandById(2);
            //Console.WriteLine(car.Description);

            //var car = carManager.GetColorById(1);
            //Console.WriteLine(car.Description);

            //var car = carManager.GetById(3);
            //car.BrandId = 2;
            //car.ColorId = 2;
            //car.ModelYear = 2021;
            //car.DailyPrice = 20000;
            //car.Description = "audi";

            //carManager.Update(car);

            //Console.WriteLine("car güncellendi");

            //var car = carManager.GetById(3);
            //carManager.Delete(car);
            //Console.WriteLine("car silindi");

            //foreach (var brand in brandManager.GetAll())
            //{
            //    Console.WriteLine(brand.BrandName);
            //}

            //var brand = new Brand { BrandId = 3, BrandName = "SLS" };
            //brandManager.Add(brand);
            //Console.WriteLine("brand eklendi");

            //var brand = brandManager.GetById(3);
            //Console.WriteLine(brand.BrandName);

            //var brand = brandManager.GetById(3);
            //brand.BrandName = "5656";
            //brandManager.Update(brand);
            //Console.WriteLine("brand güncellendi");

            //var brand= brandManager.GetById(3);
            //brandManager.Delete(brand);
            //Console.WriteLine("brand silindi");

            //foreach (var color in colorManager.GetAll())
            //{
            //    Console.WriteLine(color.ColorName);
            //}

            //var color = new Color { ColorId = 3, ColorName ="mavi"};
            //colorManager.Add(color);
            //Console.WriteLine("color eklendi");

            //var color = colorManager.GetById(3);
            //Console.WriteLine(color.ColorName);

            //var color = colorManager.GetById(3);
            //color.ColorName = " kırmızı";
            //colorManager.Update(color);
            //Console.WriteLine("color güncellendi");

            //var color = colorManager.GetById(3);
            //colorManager.Delete(color);
            //Console.WriteLine("color silindi");
        }

        private static void InMemoryGetTest(CarManager carManager)
        {
            var carId = carManager.GetById(2);
            Console.WriteLine(carId.Description);
        }

        private static CarManager InMemoryDalGetAllTest()
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.BrandId);
            }

            return carManager;
        }
    }
}
