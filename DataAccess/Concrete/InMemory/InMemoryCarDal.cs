using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id = 1, BrandId = 1, ColorId = 3, DailyPrice = 139, Description = "Audi A3", FuelId = 1,ModelYear = 2000},
                new Car{Id = 2, BrandId = 1, ColorId = 1, DailyPrice = 299, Description = "Audi A4", FuelId = 1,ModelYear = 2000},
                new Car{Id = 3, BrandId = 2, ColorId = 5, DailyPrice = 199, Description = "BMW 5.20", FuelId = 1,ModelYear = 2021},
                new Car{Id = 4, BrandId = 2, ColorId = 1, DailyPrice = 399, Description = "BMW 7.30L", FuelId = 1,ModelYear = 2022},
                new Car{Id = 5, BrandId = 1, ColorId = 3, DailyPrice = 139, Description = "Audi A5", FuelId = 1,ModelYear = 2021}
            };
        }
        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllByBrand(int brandId)
        {
           return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public Car GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Car GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.FuelId = car.FuelId;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
