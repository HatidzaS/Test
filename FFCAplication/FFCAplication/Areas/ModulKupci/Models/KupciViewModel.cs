using FFCAplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FFCAplication.Areas.ModulKupci.Models
{
    public class KupciViewModel
    {
        public DateTime DatumRegistracije { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Adresa { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string BrojTelefona { get; set; }
        public string Email { get; set; }
        public string Spol { get; set; }        
        public int OpcineId { get; set; }

        public List<Opcine> listaOpcina { get; set; }
        public IEnumerable<SelectListItem> opcine
        {

            get
            {
                List<SelectListItem> lista = new List<SelectListItem>();
                lista.Add(new SelectListItem { Value = null, Text = "Odaberite opcinu" });
                lista.AddRange(listaOpcina.Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Naziv }));
                return lista;
            }

        }
    }
}