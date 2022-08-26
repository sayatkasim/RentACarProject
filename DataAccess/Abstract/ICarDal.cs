using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        List<Car> GetAll();
        List<Car> GetAllByBrand(int brandId);
        Car GetById(int id);
        Car GetByName(string name);
        void Add(Car car);
        void Delete(Car car);
        void Update (Car car);
    }
}
