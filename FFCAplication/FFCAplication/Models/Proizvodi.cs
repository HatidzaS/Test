using FFCAplication.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FFCAplication.Models
{
    public class Proizvodi:IEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public string Naziv { get; set; }
        public float Cijena { get; set; }
        public bool Dostupan { get; set; }
        public string Slika { get; set; }
        public float ProcjesnaOcjena { get; set; }
        public string Opis { get; set; }
        public TipoviProizvoda TipoviProizvoda { get; set; }
        public int? TipoviProizvodaId { get; set; }
        
    }
}