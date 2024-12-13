using Microsoft.EntityFrameworkCore;

namespace PlayerBank.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
    {

    }

    public DbSet<Athlete> Athletes {get; set;}
    public DbSet<College> Colleges{get;set;}
}