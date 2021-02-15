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
            //CarsCrudAndDetails();

            //BrandsCrudTest();

            //ColorCrudTest();

        }

        private static void CarsCrudAndDetails()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            Console.WriteLine("*******************************************************");
            Console.WriteLine("-------------------CAR DETAILS --------------------------");
            Console.WriteLine("ID---NAME---BRANDNAME---COLORNAME---MODELYEAR---DAILYPRICE---DESCRIPTION");
            Console.WriteLine();

            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.Id + "--" + car.Name + "-------" + car.BrandName + "------" + car.ColorName + "------" + car.ModelYear + "-----" + car.DailyPrice + "TL" + "-----" + car.Description);
            }

            Console.WriteLine("*******************************************************");
            Console.WriteLine("-------------------CRUD --------------------------");
            Console.WriteLine("ID---NAME---BRANDID---COLORID---MODELYEAR---DAILYPRICE---DESCRIPTION");
            Console.WriteLine();

            carManager.Add(new Car { Id = 5, Name = "Corsa", BrandId = 2, ColorId = 2, ModelYear = 2015, DailyPrice = 175, Description = "Benzinli, manuel vites" });

            carManager.Update(new Car { Id = 5, Name = "Astra", BrandId = 2, ColorId = 3, ModelYear = 2016, DailyPrice = 215, Description = "Benzinli otomatik" });

            carManager.Delete(new Car { Id = 5 });

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id + "--" + car.Name + "-------" + car.BrandId + "------" + car.ColorId + "------" + car.ModelYear + "-----" + car.DailyPrice + "TL" + "-----" + car.Description);
            }

            Console.WriteLine("*******************************************************");
            Console.WriteLine("-------------------GET CARS BY BRAND ID --------------------------");
            Console.WriteLine("BRANDID---NAME---COLORID---MODELYEAR---DAILYPRICE---DESCRIPTION");

            foreach (var item in carManager.GetCarsByBrandId(1))
            {
                Console.WriteLine(item.BrandId + "--" + item.Name + "------" + item.ColorId + "------" + item.ModelYear + "-----" + item.DailyPrice + "TL" + "-----" + item.Description);

            }
            Console.WriteLine("*******************************************************");
            Console.WriteLine("-------------------GET CARS BY COLOR ID --------------------------");
            Console.WriteLine("COLORID---MODELYEAR---DAILYPRICE---DESCRIPTION");

            foreach (var item in carManager.GetCarsByColorId(3))
            {
                Console.WriteLine(item.ColorId + "--" + item.ModelYear + "------" + item.DailyPrice + "------" + item.Description);

            }

        }

        private static void ColorCrudTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color { Id = 4, Name = "Gri" });
            colorManager.Update(new Color { Id = 4, Name = "Metalik Gri" });
            colorManager.Delete(new Color { Id = 2 });
            Console.WriteLine(colorManager.GetById(3).Name);

            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.Name);
            }
        }

        private static void BrandCrudTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand { Id = 4, Name = "Renault" });
            brandManager.Update(new Brand { Id = 4, Name = "Renault Clio" });
            brandManager.Delete(new Brand { Id = 1 });

            Console.WriteLine(brandManager.GetById(2).Name);

            foreach (var item in brandManager.GetAll())
            {
                Console.WriteLine(item.Name);
            }
        }

        
    }
}
