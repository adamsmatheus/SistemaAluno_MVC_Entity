using System.Data.Entity;

namespace SistemaAluno.Models
{
    public class ControleContext : DbContext
    {
        public ControleContext() : base("DefaultConnection")
        {
        
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public System.Data.Entity.DbSet<SistemaAluno.Models.Usuario> Usuarios { get; set; }
    }
}