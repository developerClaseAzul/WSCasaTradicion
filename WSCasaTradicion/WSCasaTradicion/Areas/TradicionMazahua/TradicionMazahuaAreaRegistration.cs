using System.Web.Mvc;

namespace WSCasaTradicion.Areas.TradicionMazahua
{
    public class TradicionMazahuaAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "TradicionMazahua";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "TradicionMazahua_default",
                "TradicionMazahua/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}