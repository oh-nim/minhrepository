using System.Web.Mvc;

namespace SCADAMasan.Areas.SCADAGroup
{
    public class SCADAGroupAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "SCADAGroup";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "SCADAGroup_default",
                "SCADAGroup/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}