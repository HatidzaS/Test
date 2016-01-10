using FFCAplication.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FFCAplication.Models
{
    public class Nabavke:IEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime Datum { get; set; }
        public float UkupanIznos { get; set; }
        public float PDV { get; set; }

        public Dobavljaci Dobavljaci { get; set; }
        public int DobavljaciId { get; set; }

        public Zaposlenici Zaposlenici { get; set; }
        public int ZaposleniciId { get; set; }
    }
}