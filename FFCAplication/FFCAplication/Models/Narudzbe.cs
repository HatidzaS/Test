using FFCAplication.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FFCAplication.Models
{
    public class Narudzbe:IEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime Datum { get; set; }
        public float UkupanIznos { get; set; }
        public float PDV { get; set; }
        public float IznosSaPDV { get; set; }

        public Kupci Kupci { get; set; }
        public int KupciId { get; set; }

        public Zaposlenici Zaposlenici { get; set; }
        public int ZaposleniciId { get; set; }

        public StatusiNarudzbe StatusiNarudzbe { get; set; }
        public int StatusiNarudzbeId { get; set; }

        public NaciniPlacanja NaciniPlacanja { get; set; }
        public int NaciniPlacanjaId { get; set; }

    }
}