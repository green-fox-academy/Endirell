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
        
        public List<Car> GetSearchList(string q, int police, int diplomat)
        {
            if (q != null)
            {
                return carRepository.PlateFilter(q);
            }
            else if (police == 1)
            {
                return carRepository.PoliceFilter();
            }
            else if (diplomat == 1)
            {
                return carRepository.DiplomatFilter();
            }
            
            return carRepository.GetCarList();
        }

    }
}
