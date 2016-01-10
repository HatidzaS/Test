using FFCAplication.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FFCAplication.Models
{
    public class Korisnici:IEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }     
        public string Adresa { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }            
        public DateTime DatumRodjenja { get; set; }
        public string BrojTelefona { get; set; }
        public string Email { get; set; }
        public string Spol { get; set; }
        public Kupci Kupci { get; set; }
        public Zaposlenici Zaposlenici { get; set; }
        public Opcine Opcine { get; set; }
        public int OpcineId { get; set; }
    }
}