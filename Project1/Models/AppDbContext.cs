using System;
using Microsoft.EntityFrameworkCore;

namespace Project1.Models
{
    public class AppDbContext : DbContext
    {

        
        public AppDbContext(DbContextOptions<AppDbContext> options ) : base (options)
        {
            
        }

        public DbSet<Person> t_Person {get; set;}
    }
}