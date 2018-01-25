using LicensePlacePractice.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LicensePlacePractice.Repositories
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
