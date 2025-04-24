using System;
using System.Collections.Generic;
using System.Linq;

namespace CarStoreApp
{
    public class CarStore
    {
        private List<Car> cars = new List<Car>();
        private int nextId = 1;
        public void AddCar(string make, string model, decimal price)
        {
            cars.Add(new Car(nextId++, make, model, price));
        }

        public List<Car> GetAllCars()
        {
            return new List<Car>(cars);
        }

        public bool EditCar(int id, string newMake, string newModel, decimal newPrice)
        {
            var car = cars.FirstOrDefault(c => c.Id == id);
            if (car == null) return false;

            car.Make = newMake;
            car.Model = newModel;
            car.Price = newPrice;
            return true;
        }

        public bool RemoveCar(int id)
        {
            var car = cars.FirstOrDefault(c => c.Id == id);
            if (car == null) return false;

            cars.Remove(car);
            return true;
        }

        public List<Car> FindCarsByMake(string make)
        {
            return cars.Where(c => c.Make.Equals(make, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}
