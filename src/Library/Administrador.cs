namespace Library;

public class Administrador : Usuario
{
    public List<Vendedor> Vendedores { get; set; }
    
    public Administrador(string nombre, string apellido, string telefono, string email) 
        : base(nombre, apellido, telefono, email)
    {
    }
    
    public void CrearVendedor(string nombre, string apellido, string telefono, string email) 
    {
        Vendedor nuevoVendedor = new Vendedor(nombre, apellido, telefono, email);
        Vendedores.Add(nuevoVendedor); // Como me refiero a un vendedor especifico? Buscando por nombre y apellido? supongo
    }

    public void EliminarVendedor(string email) //Decido usar los Email ya que deberia ser unico
    {
        foreach (Vendedor vendedor in Vendedores)
        {
            if (vendedor.Email == email)
            {
                Vendedores.Remove(vendedor);
            }
        }
    }

    public void SuspenderVendedor(string email)
    {
        foreach (Vendedor vendedor in Vendedores)
        {
            if (vendedor.Email == email)
            {
                vendedor.Activo = false;
            }
        } 
    }
}