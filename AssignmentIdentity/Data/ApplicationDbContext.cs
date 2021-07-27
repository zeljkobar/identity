using AssignmentIdentity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentIdentity.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Car> Cars { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            //vozila
            modelBuilder.Entity<Car>().HasData(new Car { Id = 1, Marka = "Skoda", Model = "Octavia", Godiste = 2015, Gorivo = "dizel", Karoserija = "Sedan", Cijena = 9600, Snaga = 110, Opis = "Auto je u odlicnom stanju. Ima Full opremu", ZapreminaMotora = 1600, Kontakt = "067440040", Fotografija = "octavia.jpg" });
            modelBuilder.Entity<Car>().HasData(new Car { Id = 2, Marka = "Renault", Model = "Capture", Godiste = 2017, Gorivo = "benzin", Karoserija = "SUV", Cijena = 11800, Snaga = 98, Opis = "Automatik, nove gume, full oprema", ZapreminaMotora = 1500, Kontakt = "067197007", Fotografija = "captur.jpg" });
            modelBuilder.Entity<Car>().HasData(new Car { Id = 3, Marka = "Kia", Model = "Rio", Godiste = 2018, Gorivo = "hibrid", Karoserija = "karavan", Cijena = 9000, Snaga = 130, Opis = "Auto je u odlicnom stanju. Ima Full opremu", ZapreminaMotora = 1500, Kontakt = "069635869", Fotografija = "rio.jpg" });
        }
    }
}
