namespace Library;

public abstract class Usuario
{
    private string Nombre { get; }
    private string Apellido { get;}
    private string Telefono { get; }
    private string Email { get; }

    protected Usuario(string nombre, string apellido, string telefono, string email)
    {
        this.Nombre = nombre;
        this.Apellido = apellido;
        this.Telefono = telefono;
        this.Email = email;
    }

    public string ObtenerEmail()
    {
        return this.Email;
    }
}