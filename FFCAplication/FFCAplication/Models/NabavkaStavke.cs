using FFCAplication.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FFCAplication.Models
{
    public class NabavkaStavke:IEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public int Kolicina { get; set; }

        public Sirovine Sirovine { get; set; }
        public int SirovineId { get; set; }

        public Nabavke Nabavke { get; set; }
        public int NabavkeId { get; set; }
    }
}