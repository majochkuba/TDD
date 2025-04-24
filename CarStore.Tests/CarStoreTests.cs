using Xunit;
using CarStoreApp;
using System.Collections.Generic;

namespace CarStoreTests
{
    public class CarStoreTests
    {
        [Fact]
        public void AddCar_ShouldAddCarToList()
        {
            var store = new CarStore();
            store.AddCar("Toyota", "Corolla", 50000);
            var cars = store.GetAllCars();

            Assert.Single(cars);
            Assert.Equal("Toyota", cars[0].Make);
            Assert.Equal("Corolla", cars[0].Model);
            Assert.Equal(50000, cars[0].Price);
        }

        [Fact]
        public void GetAllCars_ShouldReturnCopyOfList()
        {
            var store = new CarStore();
            store.AddCar("Ford", "Fiesta", 40000);
            var cars1 = store.GetAllCars();
            var cars2 = store.GetAllCars();

            Assert.NotSame(cars1, cars2);
        }

        [Fact]
        public void EditCar_ShouldReturnTrue_WhenCarExists()
        {
            var store = new CarStore();
            store.AddCar("Audi", "A3", 80000);
            var car = store.GetAllCars()[0];

            var result = store.EditCar(car.Id, "Audi", "A4", 90000);

            Assert.True(result);
            var updated = store.GetAllCars()[0];
            Assert.Equal("A4", updated.Model);
            Assert.Equal(90000, updated.Price);
        }

        [Fact]
        public void EditCar_ShouldReturnFalse_WhenCarDoesNotExist()
        {
            var store = new CarStore();
            store.AddCar("BMW", "X3", 120000);

            var result = store.EditCar(999, "BMW", "X5", 150000);

            Assert.False(result);
        }

        [Fact]
        public void RemoveCar_ShouldReturnTrue_WhenExists()
        {
            var store = new CarStore();
            store.AddCar("Mazda", "CX-5", 100000);
            var car = store.GetAllCars()[0];

            var result = store.RemoveCar(car.Id);
            var cars = store.GetAllCars();

            Assert.True(result);
            Assert.Empty(cars);
        }

        [Fact]
        public void RemoveCar_ShouldReturnFalse_WhenNotFound()
        {
            var store = new CarStore();
            store.AddCar("Skoda", "Octavia", 70000);

            var result = store.RemoveCar(999);

            Assert.False(result);
        }

        [Fact]
        public void FindCarsByMake_ShouldReturnCorrectResult()
        {
            var store = new CarStore();
            store.AddCar("Mazda", "CX-5", 100000);
            store.AddCar("Mazda", "6", 80000);
            store.AddCar("Ford", "Focus", 60000);

            var results = store.FindCarsByMake("Mazda");

            Assert.Equal(2, results.Count);
        }

        [Fact]
        public void FindCarsByMake_ShouldIgnoreCase()
        {
            var store = new CarStore();
            store.AddCar("Tesla", "Model S", 300000);

            var results = store.FindCarsByMake("tesla");

            Assert.Single(results);
        }

        [Fact]
        public void FindCarsByMake_ShouldReturnEmptyList_WhenNotFound()
        {
            var store = new CarStore();
            store.AddCar("Toyota", "Yaris", 45000);

            var results = store.FindCarsByMake("BMW");

            Assert.Empty(results);
        }

        [Fact]
        public void AddCar_ShouldIncrementIdCorrectly()
        {
            var store = new CarStore();
            store.AddCar("A", "1", 1);
            store.AddCar("B", "2", 2);
            store.AddCar("C", "3", 3);

            var cars = store.GetAllCars();
            Assert.Equal(1, cars[0].Id);
            Assert.Equal(2, cars[1].Id);
            Assert.Equal(3, cars[2].Id);
        }

        [Fact]
        public void CanAddMultipleCars_WithSameMakeAndModel()
        {
            var store = new CarStore();
            store.AddCar("VW", "Golf", 55000);
            store.AddCar("VW", "Golf", 60000);

            var cars = store.GetAllCars();

            Assert.Equal(2, cars.Count);
            Assert.NotEqual(cars[0].Id, cars[1].Id);
        }

        [Fact]
        public void RemoveAllCars_ShouldLeaveEmptyList()
        {
            var store = new CarStore();
            store.AddCar("Ford", "Focus", 60000);
            store.AddCar("Opel", "Astra", 58000);

            foreach (var car in store.GetAllCars())
            {
                store.RemoveCar(car.Id);
            }

            Assert.Empty(store.GetAllCars());
        }
    }
}
