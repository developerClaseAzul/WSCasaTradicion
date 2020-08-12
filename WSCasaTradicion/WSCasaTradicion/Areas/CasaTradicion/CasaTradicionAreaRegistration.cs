using System.Web.Mvc;

namespace WSCasaTradicion.Areas.CasaTradicion
{
    public class CasaTradicionAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "CasaTradicion";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "CasaTradicion_default",
                "CasaTradicion/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}