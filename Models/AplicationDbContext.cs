using Microsoft.EntityFrameworkCore;

namespace be_crud_mascotas.Models
{
    public class AplicationDbContext: DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options): base(options)
        {

        }

        public DbSet<Mascota> Mascotas { get; set; }
    }
}