using System.Web.Optimization;

namespace SampleMVC.Portal.Controllers
{
    internal static class BundleConfig
    {
        internal static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/Sample/css").Include(
                          "~/Areas/Portal/Content/SampleStyleSheet.css"));
        }
    }
}