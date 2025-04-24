using CarStoreApp;

var store = new CarStore();
store.AddCar(new Car("Toyota", "Corolla", 50000));
store.AddCar(new Car("BMW", "X5", 120000));

foreach (var car in store.GetAllCars())
{
    Console.WriteLine($"{car.Make} {car.Model} - {car.Price} PLN");
}