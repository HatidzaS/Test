using System.Web.Mvc;

namespace FFCAplication.Areas.ModulZaposlenici
{
    public class ModulZaposleniciAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "ModulZaposlenici";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "ModulZaposlenici_default",
                "ModulZaposlenici/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}