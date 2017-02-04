using System.Web.Mvc;
using System.Web.Optimization;

namespace SampleMVC.Areas.Portal
{
    public class PortalAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Portal";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            string[] nameSpaces = { "SampleMVC.Portal.Controllers" };
            context.MapRoute(
                "Portal",
                "Portal/{controller}/{action}/{id}",
                new {controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: nameSpaces
            );
            RegisterBundles();
        }
        private void RegisterBundles()
        {
            SampleMVC.Portal.Controllers.BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}