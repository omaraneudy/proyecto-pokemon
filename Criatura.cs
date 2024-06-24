public class Criatura
{
    public String Nombre {get; set;}
    public double PS {get; set;}
    public double Ataque {get; set;}
    public double AtaqueEspecial {get; set;}
    public double Defensa {get; set;}
    public double DefensaEspecial {get; set;}
    public double Velocidad {get; set;}
    public int TipoPrimario {get; set;}
    public int TipoSecundario {get; set;}
    
    public Criatura(string nombre, double ps, double ataque, double ataqueEspecial, 
                    double defensa, double defensaEspecial, double velocidad,
                    int tipoPrimario, int tipoSecundario)
    {
        Nombre = nombre;
        PS = ps;
        Ataque = ataque;
        AtaqueEspecial = ataqueEspecial;
        Defensa = defensa;
        DefensaEspecial = defensaEspecial;
        Velocidad = velocidad;
        TipoPrimario = tipoPrimario;
        TipoSecundario = tipoSecundario;
    }
}