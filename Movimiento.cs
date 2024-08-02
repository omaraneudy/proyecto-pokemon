public class Movimiento
{
    public int Id {get; set;}
    public String Nombre {get; set;}
    public int Potencia {get; set;}
    public byte Tipo {get; set;}
    public byte Clase {get; set;}
    public byte Precision {get; set;}
    public byte PP {get; set;}
    public byte Blanco {get; set;}

    public Movimiento(int id, string nombre, int potencia, byte tipo, byte clase, byte precision, byte pp, byte blanco)
    {
        Id = id;
        Nombre = nombre;
        Potencia = potencia;
        Tipo = tipo;
        Clase = clase;
        Precision = precision;
        PP = pp;
        Blanco = blanco;
    }
} 