using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        public List<Car> GetCarsByBrandId(int id);
        public List<Car> GetCarsByColorId(int id);
        public void Add(Car car);
    }
}
