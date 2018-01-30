using LicensePlatePractice.Entities;
using LicensePlatePractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LicensePlatePractice.Repositories
{
    public class CarRepository
    {
        private CarContext carContext;

        public CarRepository(CarContext carContext)
        {
            this.carContext = carContext;
        }

        public List<Car> GetCarList()
        {
            return carContext.Cars.ToList();
        }

        public List<Car> PlateFilter(string q)
        {
            return carContext.Cars.Where(c => c.LicensePlate.Contains(q)).ToList();
        }

        public List<Car> PoliceFilter()
        {
            return carContext.Cars.Where(c => c.LicensePlate.StartsWith("RB")).ToList();
        }

        public List<Car> DiplomatFilter()
        {
            return carContext.Cars.Where(c => c.LicensePlate.StartsWith("DT")).ToList();
        }

        public List<Car> BrandFilter(string brandname)
        {
            return carContext.Cars.Where(c => c.CarBrand.Equals(brandname)).ToList();
        }

        

    }
}