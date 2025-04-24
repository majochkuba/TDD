# CarStore

## Opis projektu
CarStore to prosta aplikacja konsolowa służąca do zarządzania samochodami w sklepie motoryzacyjnym. Użytkownik może dodawać nowe samochody, przeglądać wszystkie dostępne auta oraz wyszukiwać je po marce.

## Klasy i metody

### Car
Reprezentuje pojedynczy samochód.

- `string Make` – marka
- `string Model` – model
- `decimal Price` – cena

### CarStore
Zarządza listą samochodów dostępnych w sklepie.

- `void AddCar(Car car)` – dodaje samochód do oferty sklepu
- `List<Car> GetAllCars()` – zwraca wszystkie samochody
- `List<Car> FindCarsByMake(string make)` – zwraca samochody o podanej marce

## Testy jednostkowe
Dla każdej metody w `CarStore` przygotowane są testy jednostkowe, początkowo z wyjątkiem `NotImplementedException`.

---

Projekt utworzony i rozwijany zgodnie z metodyką TDD.
