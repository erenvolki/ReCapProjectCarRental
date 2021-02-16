using Business.Concrete;
using DataAccess.Concrete.Entityframework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarCrudAndDetails();

            BrandCrudTest();

            ColorCrudTest();

        }

        private static void CarCrudAndDetails()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            Console.WriteLine("*******************************************************");
            Console.WriteLine("-------------------CAR DETAILS --------------------------");
            Console.WriteLine("ID---NAME---BRANDNAME---COLORNAME---MODELYEAR---DAILYPRICE---DESCRIPTION");
            Console.WriteLine();

            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(car.Id + "--" + car.Name + "-------" + car.BrandName + "------" + car.ColorName + "------" + car.ModelYear + "-----" + car.DailyPrice + "TL" + "-----" + car.Description);
            }

            Console.WriteLine("*******************************************************");
            Console.WriteLine("-------------------CRUD --------------------------");
            Console.WriteLine("ID---NAME---BRANDID---COLORID---MODELYEAR---DAILYPRICE---DESCRIPTION");
            Console.WriteLine();

            Console.WriteLine("DailiyPrice > 0 ve name uzunluğu >2 şartına göre ekleme ");

            var result1 = carManager.Add(new Car { Id = 5, Name = "Corsa", BrandId = 2, ColorId = 2, ModelYear = 2015, DailyPrice = 175, Description = "Benzinli, manuel vites" });
            Console.WriteLine(result1.Message);

            var result2 =carManager.Update(new Car { Id = 5, Name = "Astra", BrandId = 2, ColorId = 3, ModelYear = 2016, DailyPrice = 215, Description = "Benzinli otomatik" });
            Console.WriteLine(result2.Message);

            var result3 =carManager.Delete(new Car { Id = 5 });
            Console.WriteLine(result3.Message);

            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine(car.Id + "--" + car.Name + "-------" + car.BrandId + "------" + car.ColorId + "------" + car.ModelYear + "-----" + car.DailyPrice + "TL" + "-----" + car.Description);
            }

            Console.WriteLine("*******************************************************");
            Console.WriteLine("-------------------GET CARS BY BRAND ID --------------------------");
            Console.WriteLine("BRANDID---NAME---COLORID---MODELYEAR---DAILYPRICE---DESCRIPTION");

            foreach (var item in carManager.GetCarsByBrandId(1).Data)
            {
                Console.WriteLine(item.BrandId + "--" + item.Name + "------" + item.ColorId + "------" + item.ModelYear + "-----" + item.DailyPrice + "TL" + "-----" + item.Description);

            }
            Console.WriteLine("*******************************************************");
            Console.WriteLine("-------------------GET CARS BY COLOR ID --------------------------");
            Console.WriteLine("COLORID---MODELYEAR---DAILYPRICE---DESCRIPTION");

            foreach (var item in carManager.GetCarsByColorId(3).Data)
            {
                Console.WriteLine(item.ColorId + "--" + item.ModelYear + "------" + item.DailyPrice + "------" + item.Description);

            }

        }

        private static void ColorCrudTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result1 =colorManager.Add(new Color { Id = 5, Name = "Mavi" });
            Console.WriteLine(result1.Message);

            var result2=colorManager.Update(new Color { Id = 4, Name = "Metalik Gri" });
            Console.WriteLine(result2.Message);

            var result3 =colorManager.Delete(new Color { Id = 2 });
            Console.WriteLine(result3.Message);

            Console.WriteLine(colorManager.GetById(3).Data);

            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.Id + " " + color.Name);
            }
        }

        private static void BrandCrudTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result1 = brandManager.Add(new Brand { Id = 4, Name = "Renault" });
            Console.WriteLine(result1.Message);

            var result2 = brandManager.Update(new Brand { Id = 4, Name = "Renault Clio" });
            Console.WriteLine(result2.Message);

            var result3 = brandManager.Delete(new Brand { Id = 5 });
            Console.WriteLine(result3.Message);
            

            Console.WriteLine(brandManager.GetById(2));
           

            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.Name);
            }


         }


        }
}
