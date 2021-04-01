using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using System;
using Entities.Concrete;
using System.Collections.Generic;
using Entities.DTOs;

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
            if (car.Description.Length >= 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
                Console.WriteLine("Girilen bilgiler başarılı olarak kaydedildi!");
            }
            else
            {
                Console.WriteLine("Girilen bilgilerde yanlışlık var! Lütfen ürün açıklamasını 2 karakterden büyük veya günlük ücreti sıfırdan büyük giriniz. ");
            }
        }
        public void Update(Car car)
        {
            throw new NotImplementedException();
        }
        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(p=>p.BrandId==id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(p=>p.ColorId==id);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }
    }
}
