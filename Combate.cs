using System.Data.Common;

/*
formula de daño
dano = 0.01 * bonificacion * efectividad * variacion * ( ( ( (0.2 * nivel + 1) * cantidadAtaque * poderAtaque) / (25 * cantidadDefensaRival) ) + 2 )

*/


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

    public double DanoAtaque(Criatura Atacante, Criatura Atacado)
    {
        double dano = 0;
        int variacion = new Random().Next(85,100);
        double cantidadAtaque = 410;
        double cantidadDefensaRival = 450;
        //Datos para prueba (en el futuro vendrán del pokemon)
        int nivel = 100;
        double efectividad = 0.5;
        double bonificacion = 1.5;
        int poderAtaque = 150;



        //comprobación de movimiento fisico o especial
        /*if (claseMovimiento == "fisico")
          {
                cantidadAtaque = Atacante.Ataque;
          }
        else if (claseMovimiento == "especial")
        {
            cantidadAtaque = Atacante.AtaqueEspecial;
        }

        */
        dano = 0.01 * bonificacion * efectividad * variacion *  (  (0.2 * nivel + 1) * cantidadAtaque * poderAtaque) / (25 * cantidadDefensaRival) + 2; 

        return dano;
    }
}