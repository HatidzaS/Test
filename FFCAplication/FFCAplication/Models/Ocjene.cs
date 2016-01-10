using FFCAplication.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FFCAplication.Models
{
    public class Ocjene:IEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public int Ocjena { get; set; }
        public string Komentar { get; set; }

        public Kupci Kupci { get; set; }
        public int KupciId { get; set; }

        public Proizvodi Proizvodi { get; set; }
        public int ProizvodiId { get; set; }
    }
}