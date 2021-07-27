using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentIdentity.Models
{
    public interface ICarRepository
    {
        IEnumerable<Car> AllCars { get;}
        Car GetCarById(int carId);

        public void AddCar(Car car);

        public void DeleteCar(int CarId);
    }
}
