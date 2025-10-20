namespace Library;

public static class GestorInteraciones
{
    public static void NuevoMensaje(Cliente cliente, DateTime fecha, string tema, string notas, bool enviada)
    {
        Mensaje mensaje = new Mensaje(fecha, tema, notas, enviada);
        cliente.AgregarInteraccion(mensaje);
    }
    public static void NuevaLlamada(Cliente cliente, DateTime fecha, string tema, string notas, bool enviada)
    {
        Llamadas llamada = new Llamadas(fecha, tema, notas, enviada);
        cliente.AgregarInteraccion(llamada);
    }
    public static void NuevoCorreo(Cliente cliente, DateTime fecha, string tema, string notas, bool enviada)
    {
        Correo correo = new Correo(fecha, tema, notas, enviada);
        cliente.AgregarInteraccion(correo);
    }
    public static void NuevaReunion(Cliente cliente, DateTime fecha, string tema, string notas)
    {
        Reunion reunion = new Reunion(fecha, tema, notas);
        cliente.AgregarInteraccion(reunion);
    }

    public static void UltimasInteracciones()
    {
        List<Interaccion> interacciones = new List<Interaccion>();
        interacciones = Vendedor.interacciones;
        int i = 0;
        foreach (Interaccion interaccion in interacciones)
        {

            if (i < 5)
            {
                Console.WriteLine($"{interaccion}");
                i++;
            }
        }
    }

    public static void VerInteracciones(Cliente cliente)
    {
        foreach (Interaccion interaccion in cliente.Interacciones())
        {
            Console.WriteLine($"{interaccion}");
        }
    }

    public static void InteraccionesPendientes()
    {
        foreach (Online interaccion in interacciones)
        {
            if (interaccion.Respondido())
            {
            }
            else
            {
                Console.WriteLine($"{interaccion}");
            }
        }
    }
}