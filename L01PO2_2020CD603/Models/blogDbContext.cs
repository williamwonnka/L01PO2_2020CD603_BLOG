using Microsoft.EntityFrameworkCore;
using L01PO2_2020CD603.Models;

namespace L01PO2_2020CD603.Models
{
    public class blogDbContext: DbContext
    {
        public blogDbContext(DbContextOptions options) : base(options) 
        { 

        }
        public DbSet<L01PO2_2020CD603.Models.Calificaciones>? Calificaciones { get; set; }
        public DbSet<L01PO2_2020CD603.Models.Comentarios>? Comentarios { get; set; }
        public DbSet<L01PO2_2020CD603.Models.Publicaciones>? Publicaciones { get; set; }
        public DbSet<L01PO2_2020CD603.Models.Roles>? Roles { get; set; }
        public DbSet<L01PO2_2020CD603.Models.Usuarios>? Usuarios { get; set; }
    }
}
