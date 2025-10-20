namespace Library;

public class Correo: Online
{
    public Correo(DateTime fecha, string tema, string notas, bool enviada, bool respondidas) : base(fecha, tema, notas, enviada, respondidas) { }
}