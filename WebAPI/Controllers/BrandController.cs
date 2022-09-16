
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
    public class BrandController : ControllerBase
    {
        [HttpGet(Name = "GetAllBrands")]
        public List<Brand> GetAll()
        {
            IBrandService brandService = new BrandManager(new EfBrandDal());
            var result = brandService.GetAll();
            return result.ToList();
        }
    }
}
