using System.Runtime.InteropServices.JavaScript;

namespace Library;

public class Cliente
{
    private string Nombre { get; set; }
    private string Apellido { get; set; }
    private string Telefono { get; set; }
    private string Email { get; set; }
    private string Genero { get; set; }
    private DateTime FechaNacimiento { get; set; }
    private List<Etiqueta> Etiquetas = new List<Etiqueta>();
    private List<Interaccion> Interacciones = new List<Interaccion>();
    private List<Venta> Compras = new List<Venta>();
    private List<Cotizacion> Cotizaciones = new List<Cotizacion>();

    public Cliente(string nombre, string apellido, string telefono, string email, string genero, DateTime fechaNacimiento)
    {
        Nombre = nombre;
        Apellido = apellido;
        Telefono = telefono;
        Email = email;
        Genero = genero;
        FechaNacimiento = fechaNacimiento;
    }

    public string ObtenerNombre()
    {
        return this.Nombre;
    }
    public string ObtenerApellido()
    {
        return this.Apellido;
    }
    public string ObtenerTelefono()
    {
        return this.Telefono;
    }
    public string ObtenerEmail()
    {
        return this.Email;
    }
    public string ObtenerGenero()
    {
        return this.Genero;
    }
    public DateTime ObtenerFechaNacimiento()
    {
        return this.FechaNacimiento;
    }
    public List<Etiqueta> ObtenerEtiquetas()
    {
        return this.Etiquetas;
    }

    public List<Interaccion> ObtenerInteracciones()
    {
        return this.Interacciones;
    }
    public List<Venta> ObtenerCompras()
    {
        return this.Compras;
    }
    public List<Cotizacion> ObtenerCotizaciones()
    {
        return this.Cotizaciones;
    }
    
    public void CambiarNombre(string nombre)
    {
        this.Nombre = nombre;
    }
    public void CambiarApellido(string apellido)
    {
        this.Apellido = apellido;
    }
    public void CambiarTelefono(string telefono)
    {
        this.Telefono = telefono;
    }
    public void CambiarEmail(string email)
    {
        this.Email = email;
    }
    public void CambiarGenero(string genero)
    {
        this.Genero = genero;
    }

    public void AgregarInteraccion(Interaccion interaccion)
    {
        this.Interacciones.Add(interaccion);
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

    public void AgregarVenta(Venta venta)
    {
        this.Compras.Add(venta);
    }
}

