using System.Runtime.InteropServices.JavaScript;

namespace Library;

public class Cliente
{
    public string Nombre;
    public string Apellido;
    public string Telefono;
    public string Email;
    public string Genero;
    public DateTime FechaNacimiento;
    public List<Etiqueta> Etiquetas = new List<Etiqueta>();
    public List<Interaccion> Interacciones = new List<Interaccion>();
    public List<Venta> Compras = new List<Venta>();
    public List<Cotizacion> Cotizaciones = new List<Cotizacion>();

    public Cliente(string nombre, string apellido, string telefono, string email, string genero, DateTime fechaNacimiento)
    {
        Nombre = nombre;
        Apellido = apellido;
        Telefono = telefono;
        Email = email;
        Genero = genero;
        FechaNacimiento = fechaNacimiento;
    }

    public Interaccion UltimaInteraccion()
        //Recorre todas las interacciones del cliente y devuelve la última interacción 
    {
            Interaccion ultimaInteraccion = default;
            foreach (Interaccion interaccion in Interacciones) 
                if ((ultimaInteraccion.ObtenerFecha() < interaccion.ObtenerFecha()) && (interaccion.ObtenerFecha()<DateTime.Now))
                {
                    ultimaInteraccion.PonerFecha(interaccion.ObtenerFecha());
                }
            return ultimaInteraccion;
    }
}

