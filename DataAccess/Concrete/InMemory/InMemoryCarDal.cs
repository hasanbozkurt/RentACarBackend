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
            _cars = new List<Car> {
                new Car{CarName="Renault", Id=1, BrandId=1, ColorId=1, DailyPrice=250, ModelYear=2018, Description="Sembol"},
                new Car{CarName="Fiat",Id=2, BrandId=1, ColorId=1, DailyPrice=350, ModelYear=2019, Description="Doblo"},
                new Car{CarName="Wolsvagen",Id=3, BrandId=2, ColorId=2, DailyPrice=500, ModelYear=2017, Description="Passat"},
                new Car{CarName="Wolsvagen",Id=4, BrandId=2, ColorId=2, DailyPrice=600, ModelYear=2020, Description="Tiguan"},
                new Car{CarName="BMW",Id=5, BrandId=3, ColorId=2, DailyPrice=700, ModelYear=2016, Description="İ3"},
                new Car{CarName="BMW",Id=6, BrandId=3, ColorId=3, DailyPrice=950, ModelYear=2021, Description="X6"},

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p=>p.Id == car.Id);
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

        public List<Car> GetById(int Id)
        {
            return _cars.Where(p=>p.Id == Id).ToList();
        }

        public List<CarDetailDto> GetCarDetailDtos()
        {
            throw new NotImplementedException();
        }

        

        public void Uptade(Car car)
        {
            Car carToUptade = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUptade.Id = car.Id;
            carToUptade.BrandId = car.BrandId;
            carToUptade.DailyPrice = car.DailyPrice;
            carToUptade.ModelYear = car.ModelYear;
            carToUptade.Description = car.Description;
            carToUptade.ColorId = car.ColorId;
        }
    }
}
