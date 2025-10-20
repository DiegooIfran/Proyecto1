namespace Library.Tests;

public class TestGestorInteracciones
{
    [SetUp]
    public void Setup()
    {
    }
    
    [Test]
    public void AgregarCliente()
    {
        GestorCliente gestor = new GestorCliente();
        gestor.AgregarCliente("Juan", "Martinez", "091827989", "jmartin@gmail.com", "hombre", new DateTime(1990,10,20));
        Assert.That(gestor.VerTotalClientes().Count, Is.EqualTo(1));
        Assert.That(gestor.VerTotalClientes()[0].ObtenerEmail(), Is.EqualTo("jmartin@gmail.com"));
    }
    
    [Test]
    public void EliminarCliente()
    {
        GestorCliente gestor = new GestorCliente();
        gestor.AgregarCliente("Juan", "Martinez", "091827989", "jmartin@gmail.com", "hombre", new DateTime(1990,10,20));
        gestor.AgregarCliente("Lucia", "Dominguez", "091843289", "lucia@gmail.com", "mujer", new DateTime(1997,10,20));
        gestor.EliminarCliente("lucia@gmail.com");
        Assert.That(gestor.VerTotalClientes().Count, Is.EqualTo(1));
        Assert.That(gestor.VerTotalClientes()[0].ObtenerEmail(), Is.EqualTo("diego@gmail.com"));
    }
    
    [Test]
    public void VerTotalClientes()
    {
        GestorCliente gestor = new GestorCliente();
        gestor.AgregarCliente("Juan", "Martinez", "091827989", "jmartin@gmail.com", "hombre", new DateTime(1990,10,20));
        gestor.AgregarCliente("Lucia", "Dominguez", "091843289", "lucia@gmail.com", "mujer", new DateTime(1997,10,20));
        List<Cliente> resultado = gestor.VerTotalClientes();
        Assert.That(resultado, Has.Count.EqualTo(2));
    }
    
    [Test]
    public void AsignarCliente_DeberiaAgregarClienteALaListaDelVendedor()
    {
        GestorCliente gestor = new GestorCliente();
        Cliente cliente1 = new Cliente("Juan", "Martinez", "091827989", "jmartin@gmail.com", "hombre", new DateTime(1990,10,20));
        gestor.AgregarCliente("Juan", "Martinez", "091827989", "jmartin@gmail.com", "hombre", new DateTime(1990,10,20));
        Vendedor vendedor = new Vendedor("Lucia", "Dominguez", "093213589", "lucia@gmail.com");
        gestor.AsignarCliente(vendedor, gestor.VerTotalClientes()[0]);
        Assert.That(vendedor.ObtenerClientes().Contains(cliente1), Is.True);
    }
}