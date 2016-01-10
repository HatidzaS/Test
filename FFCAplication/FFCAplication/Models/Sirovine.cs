using FFCAplication.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FFCAplication.Models
{
    public class Sirovine:IEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public string Naziv { get; set; }
        public float Cijena { get; set; }
        public string MjernaJedinica { get; set; }
    }
}