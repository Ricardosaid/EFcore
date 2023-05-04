// See https://aka.ms/new-console-template for more information

using ColumnasJson.Models;

using (var context = new VentaContext())
{
    var ventasEnero = new Venta
    {
        total = 100,
        customer = new DataCustomer
        {
            name = "Saidleben1",
            address = new Address("Sirenas1", "Mexico")
        }
    };
    var ventasFebrero = new Venta
    {
        total = 102,
        customer = new DataCustomer
        {
            name = "Saidleben2",
            address = new Address("Sirenas2", "Mexico")
        }
    };
    
    var ventasMarzo = new Venta
    {
        total = 103,
        customer = new DataCustomer
        {
            name = "Saidleben3",
            address = new Address("Sirenas3", "Mexico")
        }
    };

    context.Ventas.Add(ventasEnero);
    context.Ventas.Add(ventasFebrero);
    context.Ventas.Add(ventasMarzo);

    context.SaveChanges();
}