namespace Library
{
    public static class BuscadorInteracciones
    {
        public static void VerCorreo(Cliente cliente)
        {
            Console.WriteLine($"Correos del cliente {cliente.Nombre}:");

            bool hayCorreos = false;

            foreach (var interaccion in cliente.Interacciones)
            {
                if (interaccion is Correo correo)
                {
                    Console.WriteLine($"Tema: {correo.Tema} | Fecha: {correo.Fecha.ToShortDateString()}");

                    if (!string.IsNullOrEmpty(correo.Notas))
                        Console.WriteLine($"  Nota: {correo.Notas}");

                    hayCorreos = true;
                }
            }

            if (!hayCorreos)
                Console.WriteLine("No hay correos registrados.\n");
        }

        public static void VerReunion(Cliente cliente)
        {
            Console.WriteLine($"Reuniones del cliente {cliente.Nombre}:");

            bool hayReuniones = false;

            foreach (var interaccion in cliente.Interacciones)
            {
                if (interaccion is Reunion reunion)
                {
                    Console.WriteLine($"Tema: {reunion.Tema} | Fecha: {reunion.Fecha.ToShortDateString()}");

                    if (!string.IsNullOrEmpty(reunion.Notas))
                        Console.WriteLine($"  Nota: {reunion.Notas}");

                    hayReuniones = true;
                }
            }

            if (!hayReuniones)
                Console.WriteLine("No hay reuniones registradas.\n");
        }

        public static void VerMensaje(Cliente cliente)
        {
            Console.WriteLine($"Mensajes del cliente {cliente.Nombre}:");

            bool hayMensajes = false;

            foreach (var interaccion in cliente.Interacciones)
            {
                if (interaccion is Mensaje mensaje)
                {
                    Console.WriteLine($"Tema: {mensaje.Tema} | Fecha: {mensaje.Fecha.ToShortDateString()}");

                    if (!string.IsNullOrEmpty(mensaje.Notas))
                        Console.WriteLine($"  Nota: {mensaje.Notas}");

                    hayMensajes = true;
                }
            }

            if (!hayMensajes)
                Console.WriteLine("No hay mensajes registrados.\n");
        }

        public static void VerLlamadas(Cliente cliente)
        {
            Console.WriteLine($"Llamadas del cliente {cliente.Nombre}:");

            bool hayLlamadas = false;

            foreach (var interaccion in cliente.Interacciones)
            {
                if (interaccion is Llamadas llamada)
                {
                    Console.WriteLine($"Tema: {llamada.Tema} | Fecha: {llamada.Fecha.ToShortDateString()}");

                    if (!string.IsNullOrEmpty(llamada.Notas))
                        Console.WriteLine($"  Nota: {llamada.Notas}");

                    hayLlamadas = true;
                }
            }

            if (!hayLlamadas)
                Console.WriteLine("  No hay llamadas registradas.\n");
        }
    }
}
