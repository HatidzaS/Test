using FFCAplication.Areas.ModulZaposlenici.Models;
using FFCAplication.DAL;
using FFCAplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FFCAplication.Areas.ModulZaposlenici.Controllers
{
    public class DobavljaciController : Controller
    {
        MojContext ctx = new MojContext();
        // GET: ModulZaposlenici/Dobavljaci
        
        public ActionResult Prikazi()
        {
            DobavljaciPrikaziViewModel Model = new DobavljaciPrikaziViewModel();
            Model.dobavljaci = ctx.Dobavljaci.ToList();

            return View(Model);

        }
        public ActionResult Dodaj()
        {
            DobavljaciEditViewModel Model = new DobavljaciEditViewModel();

            return View(Model);
        }

        public ActionResult Obrisi(int dobavljacId)
        {
            Dobavljaci d = ctx.Dobavljaci.Find(dobavljacId);
            ctx.Dobavljaci.Remove(d);
            ctx.SaveChanges();
            return RedirectToAction("Prikazi");

        }
        public ActionResult Uredi(int dobavljacId)
        {
            Dobavljaci d = ctx.Dobavljaci.Find(dobavljacId);
            DobavljaciEditViewModel Model = new DobavljaciEditViewModel();
            Model.Id = d.Id;
            Model.Naziv = d.Naziv;
            Model.Adresa = d.Adresa;
            Model.KontaktOsoba = d.KontaktOsoba;
            Model.BrojTelefona = d.BrojTelefona;
            Model.Banka = d.Banka;
            Model.BrojTransakcijskogRacuna = d.BrojTransakcijskogRacuna;
            Model.IsDeleted = d.IsDeleted;
            Model.Email = d.Email;
            return View("Dodaj", Model);

        }

        public ActionResult Snimi(DobavljaciEditViewModel dobavljac)
        {
            Dobavljaci dobavljacDB;
            if (dobavljac.Id == 0)
            {
                dobavljacDB = new Dobavljaci();
                ctx.Dobavljaci.Add(dobavljacDB);
            }
            else
            {
                dobavljacDB = ctx.Dobavljaci.Find(dobavljac.Id);
            }
                   
            dobavljacDB.Naziv = dobavljac.Naziv;
            dobavljacDB.Adresa = dobavljac.Adresa;
            dobavljacDB.KontaktOsoba = dobavljac.KontaktOsoba;
            dobavljacDB.Email = dobavljac.Email;
            dobavljacDB.BrojTelefona = dobavljac.BrojTelefona;
            dobavljacDB.BrojTransakcijskogRacuna = dobavljac.BrojTransakcijskogRacuna;
            dobavljacDB.Banka = dobavljac.Banka;

            ctx.SaveChanges();

            return RedirectToAction("Prikazi");
        }
    }
}