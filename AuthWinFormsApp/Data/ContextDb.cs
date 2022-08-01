using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using AuthWinFormsApp.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace AuthWinFormsApp.Data
{
    internal class ContextDb:DbContext
    {
        //Только один экземпляр
        //private ContextDb(){;}
        //private static ContextDb db = new ContextDb();
        //public static ContextDb DB() => db;
        
        //Таблицы БД
        public DbSet<User> Users => Set<User>();
        public DbSet<MaterialObject> MaterialObjects => Set<MaterialObject>();
        public DbSet<Profile> Profiles => Set<Profile>();
        public DbSet<Session> Sessions => Set<Session>();
        public DbSet<Activation> Activations => Set<Activation>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //https://www.connectionstrings.com/
            //Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;

            optionsBuilder.UseSqlServer(
                //  @"Server=VS2022\SQLEXPRESS;Database=Inventory;Trusted_Connection=True");
                @"Server=VS2022\SQLEXPRESS;Database=Inventory;User Id=inventory;Password=inventory;");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().HasIndex(e => e.Login).IsUnique();
        }
    }

}
