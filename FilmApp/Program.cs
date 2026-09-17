using FilmApp;

class program
{
    static void Main(string[] args)
    {
        Film film = new Film();
        film.Cim = "Inception";
        film.HosszPerc = 148;
        Console.WriteLine($"Film címe: {film.Cim}");
        Console.WriteLine($"Hossza: {film.HosszPerc} perc");
    }
}
