using System.Web;
using System.Web.Optimization;

namespace WebApplication2
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.

            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js"));

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/bootstrap.css",
            //          "~/Content/site.css"));


            //Arafa

            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/MediContent/vendor/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/MediContent/vendor/bootstrap/bootstrap.js"));

            //bundles.Add(new StyleBundle("~/MediContent/css").Include(
            //          "~/MediContent/bootstrap.css",
            //          "~/MediContent/site.css"));

            bundles.Add(new ScriptBundle("~/Js").Include(
                "~/MediContent/vendor/modernizr/modernizr.js",
                "~/MediContent/vendor/jquery/jquery.js",
                "~/MediContent/vendor/jquery-browser-mobile/jquery.browser.mobile.js",
                "~/MediContent/vendor/popper/umd/popper.min.js",
                "~/MediContent/vendor/bootstrap/js/bootstrap.js",
                "~/MediContent/vendor/bootstrap-datepicker/js/bootstrap-datepicker.js",
                "~/MediContent/vendor/common/common.js",
                "~/MediContent/vendor/nanoscroller/nanoscroller.js",
                "~/MediContent/vendor/magnific-popup/jquery.magnific-popup.js",
                "~/MediContent/vendor/jquery-placeholder/jquery-placeholder.js",
                "~/MediContent/js/theme.js",
                "~/MediContent/js/custom.js",
                "~/MediContent/js/theme.init.js"
                ));

            bundles.Add(new StyleBundle("~/Css").Include(
                "~/MediContent/vendor/bootstrap/css/bootstrap.css",
                "~/MediContent/vendor/animate/animate.css",
                "~/MediContent/vendor/font-awesome/css/font-awesome.css",
                "~/MediContent/vendor/magnific-popup/magnific-popup.css",
                "~/MediContent/vendor/bootstrap-datepicker/css/bootstrap-datepicker3.css",
                "~/MediContent/css/theme.css",
                "~/MediContent/css/skins/default.css",
                "~/MediContent/css/custom.css"
                ));
        }
    }
}
