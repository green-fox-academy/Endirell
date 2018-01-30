using LicensePlatePractice.Models;
using LicensePlatePractice.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LicensePlatePractice.Services
{
    public class CarService
    {
        private CarRepository carRepository;

        public CarService(CarRepository carRepository)
        {
            this.carRepository = carRepository;
        }

        public List<Car> GetList()
        {
            return carRepository.GetCarList();
        }

    }
}
