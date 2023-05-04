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
    public Address(string calle, string ciudad)
    {
        this.calle = calle;
        this.ciudad = ciudad;
    }

    public string calle { get; set; }
    public string ciudad { get; set; }

}