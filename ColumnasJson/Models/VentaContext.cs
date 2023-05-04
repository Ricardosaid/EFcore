using Microsoft.EntityFrameworkCore;

namespace ColumnasJson.Models;

public class VentaContext : DbContext
{
    //Al ser un proyecto de consola, inyectamos la cadena de conexion desde el OnConfiguring, si es desde un framework, lo hacemos desde el program
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost,1433;Database=ColumnasJson;User Id=sa;Password=SMARTpay123#;TrustServerCertificate=true");
    }
}