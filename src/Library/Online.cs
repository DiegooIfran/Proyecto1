namespace Library;

public class Online: Interaccion
{
    private bool Enviada { get; set;}
    private bool Respondidas { get; set; }
    
    protected Online(DateTime fecha, string tema, string notas, bool enviada)
        : base(fecha, tema, notas)
    {
        Enviada = enviada;
        Respondidas = false;
    }

    public void Respondida(bool respondo)
    {
        this.Respondidas = respondo;
    }

    public bool ObtenerEnviada()
    {
        return this.Enviada;
    }
    public bool ObtenerRespondido()
    {
        return this.Respondidas;
    }
}