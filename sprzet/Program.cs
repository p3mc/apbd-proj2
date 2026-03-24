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

// 5. wypozyczenie sprzetu uzytkownikowi
Wypozyczenie w1 = new Wypozyczenie(s26646, laptop1, new DateTime(), 5);
Console.WriteLine();
Console.WriteLine(w1);

// 6. zwrot z naliczeniem kary
w1.Zwroc(false);

// 7. oznaczenie sprzetu jako niedostepny
laptop1.Dostepny = false;

// 8. sprawdzenie wypozyczen uzytkownika
Wypozyczenie w2 = new Wypozyczenie(s26646, projektor1, new DateTime(), 5);
Console.WriteLine();
s26646.ListaWypozyczen();

// 9. sprawdzenie wygaslych wypozyczen
w2.Zwroc(true);
Console.WriteLine();
s26646.ListaExpiredWypozyczen();

// 10. raport stanu wypozyczalni
Console.WriteLine();
Sprzet.Raport();