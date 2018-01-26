using LicensePlatePractice.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LicensePlatePractice.Repositories
{
    public class CarRepository
    {
        public CarContext CarContext { get; set; }

        public CarRepository(CarContext carContext)
        {
            CarContext = carContext;
        }

    }
}