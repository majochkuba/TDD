using CarStoreApp;

var store = new CarStore();
bool exit = false;

while (!exit)
{
    Console.WriteLine("===== Car Store Menu =====");
    Console.WriteLine("1. Dodaj samochód");
    Console.WriteLine("2. Wyświetl wszystkie samochody");
    Console.WriteLine("3. Edytuj samochód");
    Console.WriteLine("4. Usuń samochód");
    Console.WriteLine("5. Wyszukaj samochód po marce");
    Console.WriteLine("6. Wyjście");
    Console.Write("Wybierz opcję: ");
    
    string? input = Console.ReadLine();
    Console.WriteLine();

    switch (input)
    {
        case "1":
            AddCar(store);
            break;
        case "2":
            DisplayCars(store);
            break;
        case "3":
            EditCar(store);
            break;
        case "4":
            RemoveCar(store);
            break;
        case "5":
            SearchByMake(store);
            break;
        case "6":
            exit = true;
            break;
        default:
            Console.WriteLine("Nieprawidłowy wybór.");
            break;
    }

    Console.WriteLine();
}

void AddCar(CarStore store)
{
    Console.Write("Marka: ");
    var make = Console.ReadLine();
    Console.Write("Model: ");
    var model = Console.ReadLine();
    Console.Write("Cena: ");
    decimal.TryParse(Console.ReadLine(), out decimal price);

    store.AddCar(make, model, price);
    Console.WriteLine("Samochód dodany.");
}

void DisplayCars(CarStore store)
{
    var cars = store.GetAllCars();
    if (cars.Count == 0)
    {
        Console.WriteLine("Brak samochodów.");
        return;
    }

    foreach (var car in cars)
        Console.WriteLine(car);
}

void EditCar(CarStore store)
{
    Console.Write("ID samochodu do edycji: ");
    int.TryParse(Console.ReadLine(), out int id);
    Console.Write("Nowa marka: ");
    var make = Console.ReadLine();
    Console.Write("Nowy model: ");
    var model = Console.ReadLine();
    Console.Write("Nowa cena: ");
    decimal.TryParse(Console.ReadLine(), out decimal price);

    if (store.EditCar(id, make, model, price))
        Console.WriteLine("Samochód zaktualizowany.");
    else
        Console.WriteLine("Nie znaleziono samochodu.");
}

void RemoveCar(CarStore store)
{
    Console.Write("ID samochodu do usunięcia: ");
    int.TryParse(Console.ReadLine(), out int id);

    if (store.RemoveCar(id))
        Console.WriteLine("Samochód usunięty.");
    else
        Console.WriteLine("Nie znaleziono samochodu.");
}

void SearchByMake(CarStore store)
{
    Console.Write("Marka: ");
    var make = Console.ReadLine();
    var results = store.FindCarsByMake(make);

    if (results.Count == 0)
    {
        Console.WriteLine("Brak wyników.");
    }
    else
    {
        foreach (var car in results)
            Console.WriteLine(car);
    }
}
