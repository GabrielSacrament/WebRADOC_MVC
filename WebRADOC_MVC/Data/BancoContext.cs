using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebRADOC_MVC.Models;



namespace WebRADOC_MVC.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext (DbContextOptions<BancoContext> options) : base(options)
        {
        }

        public DbSet<UsuariosModel> Usuarios { get; set; }

    }
}
