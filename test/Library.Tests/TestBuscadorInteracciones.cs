
//namespace Library.Tests
// {
//     [TestFixture]
//     public class TestBuscadorInteracciones
//     {
//         private Cliente CrearClienteConInteracciones(List<Interaccion> interacciones)
//         {
//             var cliente = new Cliente("Martin", "Perez", "099999999", "martinp@email.com", "Masculino", new DateTime(1999, 7, 1));
//             foreach (var i in interacciones)
//             {
//                 cliente.AgregarInteraccion(i);
//             }
//             return cliente;
//         }
//
//         [Test]
//         public void TestObtenerCorreos()
//         {
//             var interacciones = new List<Interaccion>
//             {
//                 // Constructor de Correo con 4 parámetros
//                 new Correo(DateTime.Today.AddDays(-1), "Oferta", "Revisar presupuesto", true),
//                 // Constructor de Reunion con 3 parámetros
//                 new Reunion(DateTime.Today, "Kickoff", "Presentación inicial")
//             };
//
//             Cliente cliente = CrearClienteConInteracciones(interacciones);
//
//             // Aun si BuscadorInteracciones no existe, esto se mantiene para cuando se implemente
//             List<Correo> correos = BuscadorInteracciones.VerCorreo(cliente);
//
//             Assert.That(correos.Count, Is.EqualTo(1));
//             Assert.That(correos[0].ObtenerTema(), Is.EqualTo("Oferta"));
//         }
//
//         [Test]
//         public void TestObtenerReuniones()
//         {
//             var interacciones = new List<Interaccion>
//             {
//                 new Reunion(DateTime.Today, "Kickoff", "Presentación inicial"),
//                 new Correo(DateTime.Today, "Oferta", "Revisar presupuesto", true)
//             };
//
//             Cliente cliente = CrearClienteConInteracciones(interacciones);
//
//             List<Reunion> reuniones = BuscadorInteracciones.VerReunion(cliente);
//
//             Assert.That(reuniones.Count, Is.EqualTo(1));
//             Assert.That(reuniones[0].ObtenerTema(), Is.EqualTo("Kickoff"));
//         }
//
//         [Test]
//         public void TestObtenerMensajes()
//         {
//             var interacciones = new List<Interaccion>
//             {
//                 new Mensaje(DateTime.Today, "Hola", "Mensaje de prueba", true),
//                 new Correo(DateTime.Today, "Oferta", "Revisar presupuesto", true)
//             };
//
//             Cliente cliente = CrearClienteConInteracciones(interacciones);
//
//             List<Mensaje> mensajes = BuscadorInteracciones.VerMensaje(cliente);
//
//             Assert.That(mensajes.Count, Is.EqualTo(1));
//             Assert.That(mensajes[0].ObtenerTema(), Is.EqualTo("Hola"));
//         }
//
//         [Test]
//         public void TestObtenerLlamadas()
//         {
//             var interacciones = new List<Interaccion>
//             {
//                 new Llamadas(DateTime.Today, "Llamada1", "Detalle llamada", false),
//                 new Correo(DateTime.Today, "Oferta", "Revisar presupuesto", true)
//             };
//
//             Cliente cliente = CrearClienteConInteracciones(interacciones);
//
//             List<Llamadas> llamadas = BuscadorInteracciones.VerLlamadas(cliente);
//
//             Assert.That(llamadas.Count, Is.EqualTo(1));
//             Assert.That(llamadas[0].ObtenerTema(), Is.EqualTo("Llamada1"));
//         }
//     }
// }
