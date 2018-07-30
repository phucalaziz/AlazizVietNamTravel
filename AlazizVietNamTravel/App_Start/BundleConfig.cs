using System.Web;
using System.Web.Optimization;

namespace AlazizVietNamTravel
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //add jquery
            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                      "~/Scripts/jquery/jquery-{version}.js",
                      "~/Scripts/jquery/jquery.validate*",
                      "~/Scripts/jquery/jquery.min.js",
                      "~/Scripts/jquery/jquery.easing.1.3.js",
                      "~/Scripts/jquery/jquery.waypoints.min.js",
                      "~/Scripts/jquery/jquery.stellar.min.js"));

            //add boostrap js
            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                      "~/Scripts/bootstrap/bootstrap.js",
                      "~/Scripts/bootstrap/bootstrap.min.js"));

            //add modernizr js
            bundles.Add(new ScriptBundle("~/bundles/js").Include("~/Scripts/modernizr/modernizr-*"));

            //add superfish js
            bundles.Add(new ScriptBundle("~/bundles/js").Include("~/Scripts/superfish/superfish.js"));

            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                        "~/Scripts/hoverIntent.js",
                        "~/Scripts/main.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/animate.css",
                      "~/Content/icomoon.css",
                      "~/Content/style.css",
                      "~/Content/superfish.css"));
        }
    }
}
