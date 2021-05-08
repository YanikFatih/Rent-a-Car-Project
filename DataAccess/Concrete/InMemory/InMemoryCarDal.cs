using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId = 1, BrandId = 1, ColorId = 2, DailyPrice = 300, Descriptions = "Renault Megane", ModelYear = "2018"},
                new Car{CarId = 2, BrandId = 2, ColorId = 1, DailyPrice = 450, Descriptions = "Honda Cıvıc", ModelYear = "2020"},
                new Car{CarId = 3, BrandId = 4, ColorId = 3, DailyPrice = 600, Descriptions = "BMW 520d", ModelYear = "2020"},
                new Car{CarId = 4, BrandId = 3, ColorId = 3, DailyPrice = 650, Descriptions = "Mercedes E250", ModelYear = "2020"},
                new Car{CarId = 5, BrandId = 2, ColorId = 1, DailyPrice = 400, Descriptions = "Honda Accord", ModelYear = "2016"},
                new Car{CarId = 6, BrandId = 1, ColorId = 2, DailyPrice = 500, Descriptions = "Renault Talısman", ModelYear = "2019"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int CarId)
        {
            return _cars.Where(c => c.CarId == CarId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Descriptions = car.Descriptions;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}

