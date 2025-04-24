using System;
using System.Collections.Generic;

namespace CarStoreApp
{
    public class CarStore
    {
        private readonly List<Car> _cars = new();
        public void AddCar(Car car)
        {
            _cars.Add(car);
        }

        public List<Car> GetAllCars()
        {
            return _cars.ToList();
        }

        public List<Car> FindCarsByMake(string make)
        {
            return _cars.Where(char => char.Make.Equals(make, StringComparision.OrdinalIgnoreCase)).ToList();
        }
    }
}
