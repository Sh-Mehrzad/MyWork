using Microsoft.EntityFrameworkCore;
using MyWork.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWork.Models
{
    public class MyWorkContext : DbContext
    {
        public DbSet<Kurumsal> Kurumsal { get; set; }
        public DbSet<Bireysel> Bireysel { get; set; }
        public DbSet<Il> Il { get; set; }
        public DbSet<Ilce> Ilce { get; set; }
        public DbSet<Paket> Paket { get; set; }
        public DbSet<PaketList> PaketList { get; set; }
        public DbSet<Reklam> Reklam { get; set; }
        public DbSet<ReklamList> ReklamList { get; set; }



        public MyWorkContext(DbContextOptions<MyWorkContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {            
            modelBuilder.ApplyConfiguration(new IlConfiguration());
            //modelBuilder.ApplyConfiguration(new IlceConfiguration());
            modelBuilder.ApplyConfiguration(new ReklamConfiguration());
            modelBuilder.ApplyConfiguration(new PaketConfiguration());
        }
    }
}
