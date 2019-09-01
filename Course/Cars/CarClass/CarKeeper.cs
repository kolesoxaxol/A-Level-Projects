using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClass
{
    public static class CarsKeeper
    {
        public static List<Car> _Cars;

        static CarsKeeper()
        {
            _Cars = new List<Car>();
        }

        public static void AddCar(Car car)
        {
            _Cars.Add(car);
        }

        public static Car[] GetCars
        {
            get { return _Cars.ToArray(); }
        }
    }
}
