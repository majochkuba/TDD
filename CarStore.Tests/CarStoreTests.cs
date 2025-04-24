using Xunit;
using CarStoreApp;
using System.Collections.Generic;

namespace CarStoreTests
{
    public class CarStoreTests
    {
        [Fact]
        public void AddCar_ShouldAddCarToStore()
        {
            var store = new CarStore();
            var car = new Car("Toyota", "Yaris", 45000);

            store.AddCar(car);

            var allCars = store.GetAllCars();
            Assert.Contains(car, allCars);
        }

        [Fact]
        public void GetAllCars_ShouldReturnAllCars()
        {
            var store = new CarStore();
            var car1 = new Car("Ford", "Focus", 30000);
            var car2 = new Car("Audi", "A4", 90000);
            store.AddCar(car1);
            store.AddCar(car2);

            var allCars = store.GetAllCars();

            Assert.Equal(2, allCars.Count);
        }

        [Fact]
        public void FindCarsByMake_ShouldReturnCorrectCars()
        {
            var store = new CarStore();
            store.AddCar(new Car("BMW", "M3", 150000));
            store.AddCar(new Car("BMW", "X6", 200000));
            store.AddCar(new Car("Toyota", "Aygo", 30000));

            var bmws = store.FindCarsByMake("BMW");

            Assert.Equal(2, bmws.Count);
            Assert.All(bmws, car => Assert.Equal("BMW", car.Make));
        }
    }
}
