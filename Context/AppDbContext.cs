using Microsoft.EntityFrameworkCore;
using webapiaspnet.Models;

namespace webapiaspnet.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public DbSet<Person> Persons { get; set; }
}