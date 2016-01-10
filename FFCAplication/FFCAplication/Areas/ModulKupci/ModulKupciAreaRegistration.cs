using System.Web.Mvc;

namespace FFCAplication.Areas.ModulKupci
{
    public class ModulKupciAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "ModulKupci";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "ModulKupci_default",
                "ModulKupci/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}