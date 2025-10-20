namespace Library.Tests;

public class TestsCliente
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestConstructor()
    {
        // Justificación: comprueba que el constructor asigne correctamente el valor de los atributos del cliente y que las listas estén vacías
        Cliente cliente = new Cliente("Juan", "Martinez", "091827989", "jmartin@gmail.com", "hombre", new DateTime(1990,10,20));
        Assert.That(cliente.Nombre, Is.EqualTo("Juan"));
        Assert.That(cliente.Apellido, Is.EqualTo("Martinez"));
        Assert.That(cliente.Telefono, Is.EqualTo("091827989"));
        Assert.That(cliente.Email, Is.EqualTo("hombre"));
        Assert.That(cliente.Genero, Is.EqualTo("Juan"));
        Assert.That(cliente.FechaNacimiento, Is.EqualTo(new DateTime(1990,10,20)));
        Assert.That(cliente.Etiquetas, Is.Empty);
        Assert.That(cliente.Interacciones, Is.Empty);
        Assert.That(cliente.Compras, Is.Empty);
        Assert.That(cliente.Cotizaciones, Is.Empty);
    }

    [Test]
    public void TestUltimaInterracion()
    {
        // Justificación: comprueba que el método ÚltimaInterración devuelva la última interración que realizó el cliente
        Cliente cliente = new Cliente("Juan", "Martinez", "091827989", "jmartin@gmail.com", "hombre",
            new DateTime(1990, 10, 20));
        Mensaje mensaje = new Mensaje(new DateTime(2025, 10, 17), "Consulta Disponibilidad",
            "Esta interesado en la compro de un mueble", false, true);
        Reunion reunion = new Reunion(new DateTime(2025, 11, 22), "Mostrar productos",
            "Quiere ver la calidad de los muebles");
        Correo correo = new Correo(new DateTime(2024, 9, 29), "Actualización estado de la compra",
            "El producto fue enviado", true, false);
        Assert.That(cliente.UltimaInteraccion(), Is.EqualTo(mensaje));
    }
}