using FFCAplication.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FFCAplication.Models
{
    public class NarudzbaStavke:IEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public int Kolicina { get; set; }

        public Proizvodi Proizvodi { get; set; }
        public int ProizvodiId { get; set; }

        public Narudzbe Narudzbe { get; set; }
        public int NarudzbeId { get; set; }
    }
}