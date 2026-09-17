using Homerseklet;



HomersekletAtvalto homer = new HomersekletAtvalto();
homer.celsius = 17;
Console.WriteLine(homer.ToFahrenheit());


double atadas = 30;

Console.WriteLine(HomersekletAtvalto.CelsiusToFahrenheit(atadas));
