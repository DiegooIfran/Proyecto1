namespace Library;

public class Cotizacion
{
    public string Producto { get; set; }
    public int Precio { get; set; }
    public DateTime Fecha { get; set; }
    public string Estado { get; set; }

    public Cotizacion(int precio, string producto)
    {
        Precio = precio;
        Producto = producto;
        Fecha = DateTime.Today;
        Estado = "Abierta";
    }

    public void CerrarVenta()
    {
        Estado = "Cerrada";
    }
}