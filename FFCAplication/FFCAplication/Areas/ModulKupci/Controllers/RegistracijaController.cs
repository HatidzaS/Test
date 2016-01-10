using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FFCAplication.Areas.ModulKupci.Models;
using FFCAplication.Models;
using FFCAplication.DAL;

namespace FFCAplication.Areas.ModulKupci.Controllers
{
    public class RegistracijaController : Controller
    {
        // GET: ModulKupci/Registracija
        MojContext ctx = new MojContext();
        public ActionResult DodajKorisnika()
        {
            KupciViewModel Model = new KupciViewModel();
            List<Opcine> lista = ctx.Opcine.ToList();

            Model.listaOpcina = lista;

            return View(Model);
        }

        public ActionResult Registracija(KupciViewModel Model)
        {
            Korisnici k = new Korisnici();
            k.Kupci = new Kupci();
            k.Ime = Model.Ime;
            k.Prezime = Model.Prezime;
            k.Lozinka = Model.Lozinka;
            k.OpcineId = Model.OpcineId;
            k.Spol = Model.Spol;
            k.KorisnickoIme = Model.KorisnickoIme;
            k.Adresa = Model.Adresa;
            k.BrojTelefona = Model.BrojTelefona;
            k.DatumRodjenja = Convert.ToDateTime(Model.DatumRodjenja);
            k.Email = Model.Email;
            k.IsDeleted = false;
            k.Kupci.DatumRegistracije = DateTime.Now;
            k.Kupci.IsDeleted = false;
            

            ctx.Korisnici.Add(k);
            ctx.SaveChanges();
           // int a = ctx.Korisnici.Where(x => x.KorisnickoIme == Model.KorisnickoIme).FirstOrDefault().Id;        



            //ku.DatumRegistracije = DateTime.Now;
            //ku.IsDeleted = false;
            //ku.Id = a;
            //ctx.Kupci.Add(ku);
            //ctx.SaveChanges();
            return RedirectToAction("DodajKorisnika");
        }
    }
}