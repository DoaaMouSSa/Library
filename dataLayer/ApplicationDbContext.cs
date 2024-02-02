using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace dataLayer
{
    public class ApplicationDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = GetDynamicConnectionString();
            optionsBuilder.UseSqlServer(connectionString);
        }

        private string GetDynamicConnectionString()
        {
            string machineName = Environment.MachineName;

            string defaultConnectionString = "Server={ServerName};Database=AccountDb;Trusted_Connection=True;";
            string servername;
            if (machineName == "DESKTOP-GSNAP69")
            { servername = "DESKTOP-GSNAP69\\SQLEXPRESS01"; }
            else
            { servername = "DESKTOP-VKVCF25\\SQLEXPRESS"; }
            return defaultConnectionString.Replace("{ServerName}", servername);
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)=>
        //    optionsBuilder.UseSqlServer(@"Server=DESKTOP-GSNAP69\SQLEXPRESS01;Database=AccountDb;Trusted_Connection=True;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Company>(ps =>
            //{
            //    ps.Property(c => c.is_deleted).HasDefaultValue(0);
            //    ps.Property(c => c.fax).HasDefaultValue("غير متوفر فاكس");
            //    ps.Property(c => c.accountant).HasDefaultValue("غير متوفر مسئول");
            //    ps.Property(c => c.email).HasDefaultValue("غير متوفر بريد الكترونى");
            //    ps.Property(c => c.website).HasDefaultValue("غير متوفر موقع الكترونى");
            //   // ps.Property(c => c.img).HasDefaultValue("");
            //});
        }
            
        public DbSet<Employee> employees { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Company> companies { get; set; }

    }
}
