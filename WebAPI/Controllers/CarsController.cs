﻿using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        [HttpGet("GetAllCars")]
        public List<Car> GetAll()
        {
            ICarService carService = new CarManager(new EfCarDal());
            var result = carService.GetAll();
            return result.ToList();
        }


        [HttpGet("GetCarDetails")]
        public List<CarDetailDto> GetCarDetails()
        {
            ICarService carService = new CarManager(new EfCarDal());
            var result = carService.GetCarDetails();
            return result.ToList();
        }

    }
}
