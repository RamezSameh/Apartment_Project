using Apartment_Project.Models;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) :base(options){}

    
    public DbSet<Apartment> Apartments { get; set; }


}

