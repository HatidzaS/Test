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
    public class SirovineController : Controller
    {
        MojContext ctx = new MojContext();
        // GET: ModulZaposlenici/Sirovine

        public ActionResult Prikazi()
        {
            SirovinePrikaziViewModel Model = new SirovinePrikaziViewModel();
            Model.sirovine = ctx.Sirovine.ToList();

            return View(Model);
        }
        public ActionResult Dodaj()
        {
            SirovineEditViewModel Model = new SirovineEditViewModel();
            return View(Model);
        }

        public ActionResult Pohrani(SirovineEditViewModel sirovina)
        {
            Sirovine sirovinaDB;
            if(sirovina.Id==0)
            {
                sirovinaDB = new Sirovine();
                ctx.Sirovine.Add(sirovinaDB);
            }
            else
            {
                sirovinaDB = ctx.Sirovine.Find(sirovina.Id);
            }
            sirovinaDB.IsDeleted = false;
            sirovinaDB.Naziv = sirovina.Naziv;
            sirovinaDB.Cijena = sirovina.Cijena;
            sirovinaDB.MjernaJedinica = sirovina.MjernaJedinica;
           
            ctx.SaveChanges();

            return RedirectToAction("Prikazi");
        }
        public ActionResult Obrisi(int sirovinaId)
        {
            Sirovine s = ctx.Sirovine.Find(sirovinaId);
            ctx.Sirovine.Remove(s);
            ctx.SaveChanges();

            return RedirectToAction("Prikazi");
        }

        public ActionResult Uredi(int sirovinaId)
        {
            Sirovine sirovina = ctx.Sirovine.Find(sirovinaId);
            SirovineEditViewModel Model = new SirovineEditViewModel();

            Model.Id = sirovina.Id;
            Model.IsDeleted = sirovina.IsDeleted;
            Model.Naziv = sirovina.Naziv;
            Model.Cijena = sirovina.Cijena;
            Model.MjernaJedinica = sirovina.MjernaJedinica;

            return View("Dodaj",Model);
        }
    }
}