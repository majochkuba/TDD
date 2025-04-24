# CarStore

## Opis aplikacji
CarStore to prosta aplikacja konsolowa, która umożliwia zarządzanie sklepem z samochodami. Użytkownik może dodawać nowe samochody, wyświetlać wszystkie dostępne samochody, edytować ich dane, usuwać oraz wyszukiwać samochody po marce.

## Funkcjonalności
- Dodawanie nowego samochodu
- Wyświetlanie listy samochodów
- Edytowanie danych samochodu
- Usuwanie samochodu
- Wyszukiwanie samochodów po marce

## Struktura aplikacji

### Klasa `Car`
Model danych przechowujący informacje o samochodzie:
- `int Id` – unikalny identyfikator samochodu
- `string Make` – marka samochodu
- `string Model` – model samochodu
- `decimal Price` – cena samochodu

### Klasa `CarStore`
Przechowuje kolekcję samochodów i zawiera logikę biznesową aplikacji.

#### Metody:
- `AddCar(string make, string model, decimal price)`  
  Dodaje nowy samochód do kolekcji z automatycznie przydzielanym ID.

- `GetAllCars()`  
  Zwraca kopię listy wszystkich samochodów zapisanych w systemie.

- `EditCar(int id, string newMake, string newModel, decimal newPrice)`  
  Umożliwia edycję danych istniejącego samochodu na podstawie jego ID.

- `RemoveCar(int id)`  
  Usuwa samochód z kolekcji na podstawie ID, jeśli taki istnieje.

- `FindCarsByMake(string make)`  
  Wyszukuje i zwraca listę samochodów o podanej marce (niewrażliwe na wielkość liter).

### Testy jednostkowe
Projekt zawiera pełny zestaw testów jednostkowych dla każdej funkcjonalności:
- Dodawanie, edytowanie i usuwanie samochodów
- Wyszukiwanie samochodów
- Sprawdzenie poprawności ID
- Testy pozytywne i negatywne przypadki użycia
