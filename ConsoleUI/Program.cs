﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            //CategoryTest();
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();

            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName + "/" + car.BrandName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CategoryTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);

            }
        }

        //    CarManager carManager = new CarManager(new EfCarDal());

        //    //CarAdd(carManager);

        //    //foreach (var car in carManager.GetAll())
        //    //{
        //    //    Console.WriteLine(car.Description);


        //    //    //"Car : " + car.Description + " , Price : " + car.DailyPrice
        //    //}

        //}

        //private static void CarAdd(CarManager carManager)
        //{
        //    //CarAddedTest(carManager);
        //}

        //private static void CarAddedTest(CarManager carManager)
        //{
        //    Car car = new Car
        //    {
        //        //Bu satıra CarId nesnesini eklemiştim, fakat PK olduğundan hata aldım. Satırı kaldırdım, bu seferde "not null hatası aldım. Daha sonra sql server dan CarId özelliklerinden Identity Specification true yaptım, düzeldi.
        //        BrandId = 1,
        //        ColorId = 1,
        //        ModelYear = 1993,
        //        DailyPrice = 0,
        //        Description = "F"
        //    };

        //    carManager.Add(car);
    }
}
