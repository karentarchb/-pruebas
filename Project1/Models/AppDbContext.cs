using System;
using Microsoft.EntityFrameworkCore;

using Project1.Models.Casino;

namespace Project1.Models
{
    public class AppDbContext : DbContext
    {

        
        public AppDbContext(DbContextOptions<AppDbContext> options ) : base (options)
        {
            
        }

        public DbSet<Person> t_Person {get; set;}
        public DbSet<Roulette> t_Roulette {get; set;}
        public DbSet<Bet> t_Bet {get; set;}
        public DbSet<Result> t_Result {get; set;}
    }
}