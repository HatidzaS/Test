using FFCAplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FFCAplication.Areas.ModulZaposlenici.Models
{
    public class DobavljaciEditViewModel
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public string Naziv { get; set; }
        public string KontaktOsoba { get; set; }
        public string Adresa { get; set; }
        public string BrojTelefona { get; set; }
        public string Email { get; set; }
        public string BrojTransakcijskogRacuna { get; set; }
        public string Banka { get; set; }

    }
}