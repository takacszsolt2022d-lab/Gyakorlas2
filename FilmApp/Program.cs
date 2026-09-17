using FilmApp;

Film film = new Film();
film.Cim = "Inception";
film.HosszPercben = 148;


Film masodikfilm = new Film();
Console.WriteLine("Kérlek adj meg egy film címet:");
masodikfilm.Cim = Console.ReadLine();

Console.WriteLine("Kérlek add meg a film hosszát:");
masodikfilm.HosszPercben =int.Parse( Console.ReadLine());


Console.WriteLine($"Film címe: {film.Cim}");
Console.WriteLine($"Hossza: {film.HosszPercben} perc");

Console.WriteLine($"Film címe: {masodikfilm.Cim}");
Console.WriteLine($"Film címe: {masodikfilm.HosszPercben}");