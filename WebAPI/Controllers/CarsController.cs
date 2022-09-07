using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        [HttpGet(Name = "GetAllCars")]
        public List<Car> GetAll()
        {
            ICarService carService = new CarManager(new EfCarDal());
            var result = carService.GetAll();
            return result.Data();
        }
    }
}
