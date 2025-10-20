using System.Runtime.InteropServices.JavaScript;

namespace Library;

public abstract class Interaccion
{
    public DateTime Fecha { get; set; }
    public string Tema { get; set; }
    public string Notas { get; set; }
    
    protected Interaccion(DateTime fecha, string tema, string notas)
    {
        Fecha = fecha;
        Tema = tema;
        Notas = notas;
    }
}
