using Microsoft.EntityFrameworkCore;
using System.Configuration;
using Microsoft.IdentityModel.Protocols;
using AlBaseet.Core.Entities;
using System.Runtime.Intrinsics.Arm;


namespace AlBaseet.Core
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<RealEstate> RealEstates { get; set; }
        public DbSet<Document> Documents { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    string Path = Environment.CurrentDirectory;
        //    Console.WriteLine(Path);
        //    string appPath = Path.Replace("Winform","Core");
        //    Console.WriteLine(appPath);
        //    optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mr.Robot\source\repos\AlBaseet\AlBaseet.Core\Database\AlBaseetDB.mdf;Integrated Security=SSPI");

        //}
        
    }
}
