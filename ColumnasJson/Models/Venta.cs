using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ColumnasJson.Models;

public class Venta
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ventaId { get; set; }

    public decimal total { get; set; }
    
}