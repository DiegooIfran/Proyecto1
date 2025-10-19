namespace Library;

public abstract class Usuario
{
    public string Nombre { get; }
    public string Apellido { get;}
    public string Telefono { get; }
    public string Email { get; }

    protected Usuario(string nombre, string apellido, string telefono, string email)
    {
        this.Nombre = nombre;
        this.Apellido = apellido;
        this.Telefono = telefono;
        this.Email = email;
    }
}