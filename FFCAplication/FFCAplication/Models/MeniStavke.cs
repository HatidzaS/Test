using FFCAplication.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FFCAplication.Models
{
    public class MeniStavke:IEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }

        public Proizvodi Proizvodi { get; set; }
        public int ProizvodiId { get; set; }

        public Meni Meni { get; set; }
        public int MeniId { get; set; }


    }
}