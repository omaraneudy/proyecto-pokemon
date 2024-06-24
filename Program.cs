// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Combate combate = new Combate();

Criatura criatura1 = new Criatura("Sol", 100, 55, 60, 55, 75, 90, 1, 0);
Criatura criatura2 = new Criatura("Luna", 90, 80, 85, 30, 50, 90, 2, 0);

combate.Turno(criatura1, criatura2);
