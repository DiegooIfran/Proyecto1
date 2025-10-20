namespace Library;

public class Online: Interaccion
{
    private bool Enviada { get; set;}
    private bool Respondidas { get; set; }
    
    protected Online(DateTime fecha, string tema, string notas, bool enviada, bool respondidas)
        : base(fecha, tema, notas)
    {
        Enviada = enviada;
        Respondidas = respondidas;
    }
}