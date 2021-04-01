using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;

        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car{CarId = 1, BrandId = 1, ColorId = 1, ModelYear = 1986, DailyPrice = 100, Description = "Chevrolet Pickup Beyaz"},
                new Car{CarId = 2, BrandId = 1, ColorId = 2, ModelYear = 1988, DailyPrice = 85, Description = "Chevrolet Sedan Siyah"},
                new Car{CarId = 3, BrandId = 2, ColorId = 1, ModelYear = 1995, DailyPrice = 95, Description = "Ford Mustang Beyaz"},
                new Car{CarId = 4, BrandId = 2, ColorId = 2, ModelYear = 1996, DailyPrice = 75, Description = "Ford Mondeo Siyah"},
                new Car{CarId = 5, BrandId = 2, ColorId = 3, ModelYear = 1990, DailyPrice = 60, Description = "Ford Fiesta Mavi"},
            };
        }
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(c => c.BrandId == car.BrandId);

            _car.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllById(int carId)
        {
            return _car.Where(c => c.CarId == carId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
