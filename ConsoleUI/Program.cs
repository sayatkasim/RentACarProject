// See https://aka.ms/new-console-template for more information

using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

CarManager carManager = new CarManager(new EfCarDal());

foreach (var car in carManager.GetAll())
{
    Console.WriteLine(car.Description);
}
