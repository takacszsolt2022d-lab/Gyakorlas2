using DiakApp;

Diak parameternelkul = new Diak();

Diak egyparameteres = new Diak("Nagy Alma");

Diak ketparameteres = new Diak("Kovvács Béla", 2.8);


Console.WriteLine($"Paraméter nélküli konstruktor{parameternelkul}, Átlag : {parameternelkul}");

Console.WriteLine($"Egy paraméteres konstruktor{egyparameteres}, Átlag: {egyparameteres}");

Console.WriteLine($"Két paraméteres konstruktor{ketparameteres}, Átlag: {ketparameteres}");


