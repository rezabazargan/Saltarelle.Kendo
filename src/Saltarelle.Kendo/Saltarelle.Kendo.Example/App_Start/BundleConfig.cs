using System.Web;
using System.Web.Optimization;

namespace Saltarelle.Kendo.Example
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));


            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*", "~/Scripts/kendo.modernizr.custom.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/SaltarrleScripts")
               .Include("~/Scripts/mscorlib.js")
               .Include("~/Scripts/Saltarelle.Kendo.test.js"));


            bundles.Add(new ScriptBundle("~/Script/Kendo")
                .Include("~/Content/kendo/2014.2.716/kendo*") );

            bundles.Add(new StyleBundle("~/Content/Kendo")
                    .Include("~/Content/kendo/2014.2.716/kendo.common.min.css")
                    .Include("~/Content/kendo/2014.2.716/kendo.mobile.all.min.css")
                    .Include("~/Content/kendo/2014.2.716/kendo.dataviz.min.css")
                    .Include("~/Content/kendo/2014.2.716/kendo.metro.min.css")
                    .Include("~/Content/kendo/2014.2.716/kendo.dataviz.metro.min.css")
                    .Include("~/Content/kendo/2014.2.716/kendo.rtl.min.css")
                    );


        }
    }
}