using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ufasforms.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<Etablissement> Etablissements { get; set; }
    public DbSet<Faculte> Facultes { get; set; }
    public DbSet<Domaine> Domaines { get; set; }
    public DbSet<Filiere> Filieres { get; set; }
    public DbSet<Specialite> Specialites { get; set; }
}
