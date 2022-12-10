using Microsoft.EntityFrameworkCore;
using Skladište.DAL.Models;

namespace Skladište.DAL.Context;

public class SkladišteDbContext : DbContext
{
    public SkladišteDbContext(DbContextOptions<SkladišteDbContext> options) : base(options)
    {
    }

    public DbSet<Kategorija> Kategorija  { get; set; }
    public DbSet<Stavka> Stavke { get; set; }

}
