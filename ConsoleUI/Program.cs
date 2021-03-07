using Business.Concrete;
using Core.Entities.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.Entityframework;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarCrudAndDetails();

            //BrandCrudTest();

            //ColorCrudTest();

            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            

    //        Console.WriteLine("---KİRAYA VERİLEN VE TABLOYA EKLENEN ARAÇLAR---");
    //        Console.WriteLine();
    //        Console.WriteLine();

    //        Console.WriteLine("ID\tCARID\tCUSTOMERID\tRENTDATE\t\t RETURNDATE");

    //        var result = rentalManager.Add(new Rental { Id = 4, CarId = 4, CustomerId = 1, RentDate = new DateTime(2021, 2, 7) });
    //        Console.WriteLine(result.Message);

    //        foreach (var item in rentalManager.GetAll().Data)
    //        {
    //            Console.WriteLine(item.Id + "-----" + item.CarId + "----------" + item.CustomerId + "-------" + item.RentDate + "-------" + item.ReturnDate);

    //        }

    //        Console.WriteLine("-------------------------------------------------------------------------");

    //        Console.WriteLine("Araç teslim ediliyor ve teslim tarihi veriliyor");
    //        Console.WriteLine(rentalManager.Deliver(3).Message);

    //        foreach (var item in rentalManager.GetAll().Data)
    //        {
    //            Console.WriteLine(item.Id + "----- " + item.CarId + "----------" + item.CustomerId + "-------" + item.RentDate + "\t\t" + item.ReturnDate);

    //        }

    //        Console.WriteLine("------------------------------------------------------------------------------------");

    //        Console.WriteLine("------KİRALAMA İMKANI OLAN ARAÇLAR---------");
    //        Console.WriteLine();
            
    //        Console.WriteLine("ID\tCARID\tCUSTOMERID\tRENTDATE\t\t RETURNDATE");

    //        foreach (var item in rentalManager.AvailableCar().Data)
    //        {
    //            Console.WriteLine(item.Id +"\t" + item.CarId+"\t" + item.CustomerId + "\t" + item.RentDate + "\t"+ item.ReturnDate);
    //        }

    //        Console.WriteLine("---------------------------------------------------------------------------------------");

    //        Console.WriteLine("-------------ARAÇ KİRALAMA DETAY TABLOSU--------------");

    //        foreach (var detail in rentalManager.GetRentalDetails().Data)
    //        {
    //            Console.WriteLine(detail.Id + detail.CarName + detail.Brandname + detail.Username + detail.CustomerName + detail.DailyPrice + detail.RentDate + detail.ReturnDate);
    //        }

    //        Console.WriteLine("------------------------------------------------------------------------------------------");
    //        Console.WriteLine("-------------USER CRUD OPERATION--------------");

    //        UserManager userManager = new UserManager(new EfUserDal());

    //        var user1 = userManager.Add(new User {Id=1, FirstName="Volkan", LastName="EREN", Email="a@bmail.com", Password="111" });
    //        var user2 = userManager.Add(new User { Id = 2, FirstName = "Derya", LastName = "EREN", Email = "a@bmail.com", Password = "222" });
    //        var userDelete = userManager.Delete(new User { Id = 1 });
    //        var userUpdate = userManager.Update(new User { Id = 2, Password = "000" });

    //        Console.WriteLine("------------------------------------------------------------------------------------------");
    //        Console.WriteLine("-------------CUSTOMER CRUD OPERATION--------------");

    //        CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

    //        var customer1 = customerManager.Add(new Customer { Id = 4, CompanyName = "TikTok A.Ş" });
    //        var customer2 = customerManager.Add(new Customer { Id = 5, CompanyName = "Hoppa Ltd.Şti" });
    //        var customer3 = customerManager.Add(new Customer { Id = 6, CompanyName = "Fırıldak A.Ş" });
    //        var customerDelete = customerManager.Delete(new Customer { Id = 5 });
    //        var customerUpdated = customerManager.Update(new Customer { Id = 4, CompanyName = "TokTik A.Ş" });

    //    }


    //    private static void CarCrudAndDetails()
    //    {
    //        CarManager carManager = new CarManager(new EfCarDal());

    //        Console.WriteLine("*******************************************************");
    //        Console.WriteLine("-------------------CAR DETAILS --------------------------");
    //        Console.WriteLine("ID---NAME---BRANDNAME---COLORNAME---MODELYEAR---DAILYPRICE---DESCRIPTION");
    //        Console.WriteLine();

    //        foreach (var car in carManager.GetCarDetails().Data)
    //        {
    //            Console.WriteLine(car.Id + "--" + car.Name + "-------" + car.BrandName + "------" + car.ColorName + "------" + car.ModelYear + "-----" + car.DailyPrice + "TL" + "-----" + car.Description);
    //        }

    //        Console.WriteLine("*******************************************************");
    //        Console.WriteLine("-------------------CRUD --------------------------");
    //        Console.WriteLine("ID---NAME---BRANDID---COLORID---MODELYEAR---DAILYPRICE---DESCRIPTION");
    //        Console.WriteLine();

    //        Console.WriteLine("DailiyPrice > 0 ve name uzunluğu >2 şartına göre ekleme ");

    //        var result1 = carManager.Add(new Car { Id = 5, Name = "Corsa", BrandId = 2, ColorId = 2, ModelYear = 2015, DailyPrice = 175, Description = "Benzinli, manuel vites" });
    //        Console.WriteLine(result1.Message);

    //        var result2 = carManager.Update(new Car { Id = 5, Name = "Astra", BrandId = 2, ColorId = 3, ModelYear = 2016, DailyPrice = 215, Description = "Benzinli otomatik" });
    //        Console.WriteLine(result2.Message);

    //        var result3 = carManager.Delete(new Car { Id = 5 });
    //        Console.WriteLine(result3.Message);

    //        foreach (var car in carManager.GetAll().Data)
    //        {
    //            Console.WriteLine(car.Id + "--" + car.Name + "-------" + car.BrandId + "------" + car.ColorId + "------" + car.ModelYear + "-----" + car.DailyPrice + "TL" + "-----" + car.Description);
    //        }

    //        Console.WriteLine("*******************************************************");
    //        Console.WriteLine("-------------------GET CARS BY BRAND ID --------------------------");
    //        Console.WriteLine("BRANDID---NAME---COLORID---MODELYEAR---DAILYPRICE---DESCRIPTION");

    //        foreach (var item in carManager.GetCarsByBrandId(1).Data)
    //        {
    //            Console.WriteLine(item.BrandId + "--" + item.Name + "------" + item.ColorId + "------" + item.ModelYear + "-----" + item.DailyPrice + "TL" + "-----" + item.Description);

    //        }
    //        Console.WriteLine("*******************************************************");
    //        Console.WriteLine("-------------------GET CARS BY COLOR ID --------------------------");
    //        Console.WriteLine("COLORID---MODELYEAR---DAILYPRICE---DESCRIPTION");

    //        foreach (var item in carManager.GetCarsByColorId(3).Data)
    //        {
    //            Console.WriteLine(item.ColorId + "--" + item.ModelYear + "------" + item.DailyPrice + "------" + item.Description);

    //        }

    //    }

    //    private static void ColorCrudTest()
    //    {
    //        ColorManager colorManager = new ColorManager(new EfColorDal());
    //        var result1 = colorManager.Add(new Color { Id = 5, Name = "Mavi" });
    //        Console.WriteLine(result1.Message);

    //        var result2 = colorManager.Update(new Color { Id = 4, Name = "Metalik Gri" });
    //        Console.WriteLine(result2.Message);

    //        var result3 = colorManager.Delete(new Color { Id = 2 });
    //        Console.WriteLine(result3.Message);

    //        Console.WriteLine(colorManager.GetById(3).Data);

    //        foreach (var color in colorManager.GetAll().Data)
    //        {
    //            Console.WriteLine(color.Id + " " + color.Name);
    //        }
    //    }

    //    private static void BrandCrudTest()
    //    {
    //        BrandManager brandManager = new BrandManager(new EfBrandDal());
    //        var result1 = brandManager.Add(new Brand { Id = 4, Name = "Renault" });
    //        Console.WriteLine(result1.Message);

    //        var result2 = brandManager.Update(new Brand { Id = 4, Name = "Renault Clio" });
    //        Console.WriteLine(result2.Message);

    //        var result3 = brandManager.Delete(new Brand { Id = 5 });
    //        Console.WriteLine(result3.Message);


    //        Console.WriteLine(brandManager.GetById(2));


    //        foreach (var brand in brandManager.GetAll().Data)
    //        {
    //            Console.WriteLine(brand.Name);
    //        }


        }


    }
}
