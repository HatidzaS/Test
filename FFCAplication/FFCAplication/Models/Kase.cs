using FFCAplication.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FFCAplication.Models
{
    public class Kase:IEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public string Adresa { get; set; }
        public string Naziv { get; set; }
        public string Grad { get; set; }
        public string BrojKase { get; set; }
    }
}