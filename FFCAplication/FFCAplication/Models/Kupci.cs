using FFCAplication.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FFCAplication.Models
{
    public class Kupci:IEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DatumRegistracije { get; set; }
        

        public Korisnici Korisnici { get; set; }
    }
}