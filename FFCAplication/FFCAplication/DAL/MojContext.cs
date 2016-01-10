using FFCAplication.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FFCAplication.DAL
{
    public class MojContext:DbContext
    {

        public MojContext()
            : base("Name=MojConnectionString")
        {

        }
        //tabele
        public DbSet<Korisnici> Korisnici { get; set; }         
        public DbSet<Zaposlenici>Zaposlenici{ get; set; }
        public DbSet<Kupci>Kupci { get; set; }
        public DbSet<Opcine> Opcine { get; set; }
        public DbSet<Dobavljaci> Dobavljaci { get; set; }
        public DbSet<Nabavke> Nabavke { get; set; }
        public DbSet<NabavkaStavke> NabavkaStavke { get; set; }
        public DbSet<Sirovine> Sirovine { get; set; }
        public DbSet<Narudzbe> Narudzbe { get; set; }
        public DbSet<Racuni> Racuni { get; set; }
        public DbSet<StatusiNarudzbe> StatusiNarudzbe { get; set; }
        public DbSet<NaciniPlacanja> NaciniPlacanja { get; set; }
        public DbSet<NarudzbaStavke> NarudzbaStavke { get; set; }
        public DbSet<Ocjene> Ocjene { get; set; }
        public DbSet<Proizvodi> Proizvodi { get; set; }
        public DbSet<MeniStavke> MeniStavke { get; set; }
        public DbSet<Meni> Meni { get; set; }
        public DbSet<Kase> Kasa { get; set; }

        public DbSet<TipoviProizvoda> TipoviProizvoda { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //posebne relacije

            modelBuilder.Entity<Korisnici>().HasOptional(x => x.Kupci).WithRequired(x => x.Korisnici);
            modelBuilder.Entity<Korisnici>().HasOptional(x => x.Zaposlenici).WithRequired(x => x.Korisnici);

        }



    }
}