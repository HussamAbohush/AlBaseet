using AlBaseet.Core.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using Microsoft.IdentityModel.Protocols;


namespace AlBaseet.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mr.Robot\source\repos\AlBaseet\AlBaseet.DAL\Database\AlBaseetDB.mdf;Integrated Security=True");

        }
        
    }
}
