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
            CarManager carManager = new CarManager(new EfCarDal());

            //Console.WriteLine("*******************************************************");
            //Console.WriteLine("---------------GET ALL---------------------------------");
            //Console.WriteLine("ID---NAME---MODELYEAR---DAILYPRICE---DESCRIPTION");
            //Console.WriteLine();

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Id + "--" + car.Name + "-------" + car.ModelYear + "-------" + car.DailyPrice + "TL" + "--------" + car.Description);
            //}

            //Console.WriteLine();
            //Console.WriteLine("---------------GET CARS BY BRAND ID--------------------");
            //Console.WriteLine("*******************************************************");

            //foreach (var a in carManager.GetCarsByBrandId(3))
            //{
            //    Console.WriteLine(a.BrandId + "--" + a.Name);
            //}

            //Console.WriteLine();
            //Console.WriteLine("---------------GET CARS BY COLOR ID--------------------");
            //Console.WriteLine("*******************************************************");

            //foreach (var color in carManager.GetCarsByColorId(1))
            //{
            //    Console.WriteLine(color.Description);
            //}

            //Console.WriteLine();
            //Console.WriteLine("---------------CRUD--------------------");
            //Console.WriteLine("*******************************************************");

            Car k = new Car { Id = 5, Name = "Corsa", BrandId = 2, ColorId = 1, ModelYear = 2015, DailyPrice = 130, Description = "Benzinli manuel vites" };
            carManager.Add(k);
            Console.WriteLine("Kayıt eklendi");
            Console.WriteLine("-----------------------------------------");

            foreach (var p in carManager.GetAll())
            {
                Console.WriteLine(p.Id + "--" + p.Name + "-------" + p.ModelYear + "-------" + p.DailyPrice + "TL" + "--------" + p.Description);
            }

            Console.WriteLine("-----------------------------------------");

            k.ModelYear = 2016;
            k.DailyPrice = 140;


            carManager.Update(k);
            Console.WriteLine("Kayıt Güncellendi");
            foreach (var ca in carManager.GetAll())
            {
                Console.WriteLine(ca.Id + "--" + ca.Name + "-------" + ca.ModelYear + "-------" + ca.DailyPrice + "TL" + "--------" + ca.Description);
            }

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("-----------------------------------------");
            
            carManager.Delete(k);
            Console.WriteLine("Kayıt silindi");

            foreach (var sil in carManager.GetAll())
            {
                Console.WriteLine(sil.Id + "--" + sil.Name + "-------" + sil.ModelYear + "-------" + sil.DailyPrice + "TL" + "--------" + sil.Description);
            }



        }
    }
}
