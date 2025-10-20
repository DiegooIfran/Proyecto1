namespace Library;

public static class Panel
{
    public static void ImprimirPanel(Vendedor vendedor)
    {
        Console.WriteLine($"Panel del vendedor: {vendedor.Nombre}");

        // total de clientes
        var clientes = vendedor.VerClientes();
        Console.WriteLine($"Clientes totales: {clientes.Count}");

        //interacciones recientes de todos los clientes
        List<Interaccion> todasLasInteracciones = new();

        foreach (var cliente in clientes)
        {
            if (cliente.Interacciones != null)
            {
                todasLasInteracciones.AddRange(cliente.Interacciones);
            }
        }

        if (todasLasInteracciones.Count == 0)
        {
            Console.WriteLine("No hay interacciones registradas");
        }
        else
        {
            // Ordeno por fecha descendente
            todasLasInteracciones.Sort((a, b) => b.Fecha.CompareTo(a.Fecha));

            Console.WriteLine("Interacciones recientes:");
            int mostradas = 0;
            foreach (var interaccion in todasLasInteracciones)
            {
                Console.WriteLine(
                    $" {interaccion.GetType().Name}: {interaccion.Tema} {interaccion.Fecha.ToShortDateString()}");
                mostradas++;
                if (mostradas == 5) break; // mostrar solo 5 más recientes
            }
        }

        Console.WriteLine();

        // reuniones próximas (usando BuscadorInteracciones)
        Console.WriteLine("Próximas reuniones:");

        bool hayReuniones = false;

        foreach (var cliente in clientes)
        {
            BuscadorInteracciones.VerReunion(cliente);
            hayReuniones = true;
        }

        if (!hayReuniones)
        {
            Console.WriteLine("No hay reuniones próximas");
        }
    }
}