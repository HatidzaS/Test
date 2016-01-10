using FFCAplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FFCAplication.Areas.ModulZaposlenici.Models
{
    public class SirovineEditViewModel
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public string Naziv { get; set; }
        public float Cijena { get; set; }
        public string MjernaJedinica { get; set; }
    }
}