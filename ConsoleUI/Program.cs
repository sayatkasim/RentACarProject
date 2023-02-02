// See https://aka.ms/new-console-template for more information

using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

CarManager carManager = new CarManager(new EfCarDal(),new BrandManager(new EfBrandDal()));

var result = carManager.GetCarDetails();

if (result.Success==true)
{
    foreach (var car in result.Data)
    {
        Console.WriteLine(car.BrandName + " "+ car.Description);
    }
}
else
{
    Console.WriteLine(result.Message);
}

