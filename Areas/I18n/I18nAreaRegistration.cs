using System.Web.Mvc;

namespace EF7TEST.Areas.I18n
{
    public class I18nAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "I18n";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "I18n_default",
                "I18n/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}