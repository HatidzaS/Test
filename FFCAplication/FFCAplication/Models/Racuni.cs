using FFCAplication.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FFCAplication.Models
{
    public class Racuni:IEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }

        public Narudzbe Narudzbe { get; set; }
        public int NarudzbeId { get; set; }

        public Kase Kase { get; set; }
        public int KaseId { get; set; }
    }
}