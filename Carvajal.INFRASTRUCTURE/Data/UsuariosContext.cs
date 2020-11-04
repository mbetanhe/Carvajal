using Carvajal.CORE.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Carvajal.INFRASTRUCTURE.Data
{
    public partial class UsuariosContext : DbContext
    {
        public UsuariosContext()
        {
        }

        public UsuariosContext(DbContextOptions<UsuariosContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cards> Cards { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //Aplicamos las configuraciones
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
