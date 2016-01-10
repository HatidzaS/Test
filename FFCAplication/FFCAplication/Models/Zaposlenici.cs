using FFCAplication.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FFCAplication.Models
{
    public class Zaposlenici:IEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public bool Menadzer { get; set; }
        public string Jmbg { get; set; }
        public string BrojLicneKarte { get; set; }
        public string BrojTransakcijskogRacuna { get; set; }
        public string BrojRadneKnjizice { get; set; }
        public string Banka { get; set; }
        public DateTime DatumZaposlenja { get; set; }
        public float Plata { get; set; }
        public TipoviZaposlenika TipoviZaposlenika { get; set; }
        public int ?TipoviZaposlenikaId { get; set; }
        public Korisnici Korisnici { get; set; }
    }

}