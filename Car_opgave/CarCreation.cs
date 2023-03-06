using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_opgave
{
    public class CarCreation
    {
        public int _nextID;
        public List<Car_Main> _Cars;

        public CarCreation()
        {
            _nextID = 1;
            _Cars = new List<Car_Main>();
            {
                new Car_Main() { Id = _nextID++, Model = "Lambo", Price = 3750000, LicensePlate = 9992124 };
                new Car_Main() { Id = _nextID++, Model = "Peugeot", Price = 45000, LicensePlate = 1234567 };
                new Car_Main() { Id = _nextID++, Model = "Mclaren", Price = 7120000, LicensePlate = 1233137 };
            }
        }
    }
}
