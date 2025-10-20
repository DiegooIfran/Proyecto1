using System.Globalization;
using System.Runtime.InteropServices;

namespace Library;

public class Vendedor : Usuario
{
    private List<Cliente> Clientes { get; set; }
    public bool Activo { get; set; }
    
    public Vendedor(string nombre, string apellido, string telefono, string email) 
        : base(nombre, apellido, telefono, email)
    {
        this.Activo = true;
    }

    public void VerClientes()
    {
        foreach (Cliente cliente in Clientes)
        {
            Console.WriteLine($"{cliente.ObtenerNombre()} {cliente.ObtenerApellido}");
        }
    }

    public void FestejarCumpleanos()
    {
        foreach (Cliente cliente in Clientes)
        {
            if (cliente.ObtenerFechaNacimiento() == DateTime.Today)
            {
                GestorInteraciones.NuevoMensaje(cliente, DateTime.Today, "Feliz cumpleaños!!",
                    "Feliz cumpleaños! ¿Porque no lo festejas con los descuentos especiales que tenemos para vos?", true);
            }
        }
    }

    public void Camapana(Etiqueta etiqueta, string anuncio)
    {
        foreach (Cliente cliente in Clientes)
        {
            if (cliente.ObtenerEtiquetas().IndexOf(etiqueta) != -1)
            {
                // Aca deberia crear un nuevo mensaje y agregarlo en las interacciones del usuario 
                // Crear un mensaje con el anuncio de la campaña
            }
        }
    }

    public void NuevaCotizacion(Cliente cliente, int precio, string producto)
    {
        Cotizacion nuevaCotizacion = new(cliente, precio, producto);
    }

    public void TotalVentas(DateTime fechaInicio, DateTime fechaFinal)
    {
        foreach (Cliente cliente in Clientes)
        {
            foreach (Venta compra in cliente.ObtenerCompras())
            {
                if (fechaInicio <= compra.Fecha && compra.Fecha <= fechaFinal)
                {
                    Console.WriteLine($"{cliente} compro {compra.Producto} por {compra.Precio} el {compra.Fecha}");
                }
            }
        }
    }

    public void VerPanel()
    {
        Panel.ImprimirPanel(this);
    }
}