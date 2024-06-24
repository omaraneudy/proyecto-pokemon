using System.Data.Common;

public class Combate
{
    public void Turno(Criatura criatura1, Criatura criatura2)
    {
        if (criatura1.Velocidad > criatura2.Velocidad)
        {
            Console.WriteLine("criatura1 ataca");
        }
        else if (criatura2.Velocidad > criatura1.Velocidad)
        {
            Console.WriteLine("criatura2 ataca");
        }
        else if (criatura1.Velocidad == criatura2.Velocidad)
        {
            Random random = new Random();
            int primeroEnAtacar = random.Next(1, 11);

            if (primeroEnAtacar <= 5)
                Console.WriteLine($"criatura1 ataca random {primeroEnAtacar}");
            else if (primeroEnAtacar >= 6)
                Console.WriteLine($"criatura2 ataca random {primeroEnAtacar}");
        }
    }
}