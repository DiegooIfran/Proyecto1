namespace Library;

public static class ModificadorCliente
{
    static void ModificarNombre(string nombre, Cliente cliente)
    {
        cliente.CambiarNombre(nombre);
    }
    
    static void ModificarApellido(string apellido, Cliente cliente)
    {
        cliente.CambiarApellido(apellido);
    }
    
    static void ModificarTelefono(string telefono, Cliente cliente)
    {
        cliente.CambiarTelefono(telefono);
    }
    
    static void ModificarEmail(string email, Cliente cliente)
    {
        cliente.CambiarEmail(email);
    }
}