using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ColumnasJson.Models;

public class Venta
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ventaId { get; set; }

    public decimal total { get; set; }
    public DataCustomer customer { get; set; }
    
}

public class DataCustomer
{
    public string name { get; set; }
    public Address address { get; set; }
    
}

public class Address
{
    private string calle { get; set; }
    private string ciudad { get; set; }
    public Address(string street, string city)
    {
        calle = street;
        ciudad = city;
    }
    
}