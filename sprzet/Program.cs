// See https://aka.ms/new-console-template for more information


using sprzet;

// 1. tworzenie nowego uzytkownika
Uzytkownik s26646 = new Uzytkownik(UserType.Student, "Krzysztof", "Bobr");

// 2. tworzenie nowego sprzetu
Sprzet projektor1 = new Projektor("Supernowyprojektor", "przyklad", 0);
Sprzet laptop1 = new Laptop("AIO", "dcjdabcjhbcjac", "axbshaxjav");
laptop1.Dostepny = false;

// 3. lista sprzetu + status
Sprzet.Pokaz();

// 4. wyswietlenie dostepnego sprzetu
Sprzet.PokazDostepne();