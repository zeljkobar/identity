using AssignmentIdentity.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentIdentity.Models
{
    public class CarRepository:ICarRepository
    {
        private readonly ApplicationDbContext appDbContext;

        public CarRepository(ApplicationDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public IEnumerable<Car> AllCars 
        {
            get
            {
                var cars = appDbContext.Cars;
                return cars;
            }
        }

        public void AddCar(Car car)
        {
            if (car != null)
            {
            
                appDbContext.Cars.Add(car);
                appDbContext.SaveChanges();
            }
        }

        public void DeleteCar(int CarId)
        {
            var car = appDbContext.Cars.FirstOrDefault(c => c.Id == CarId);
            appDbContext.Cars.Remove(car);
            appDbContext.SaveChanges();
        }

        public Car GetCarById(int carId)
        {
            var car = appDbContext.Cars.FirstOrDefault(c => c.Id == carId);
            return car;
        }
    }
}
