using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace ITPAC.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                       "~/Scripts/modernizr-2.6.2.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/font-awesome.min.css",
                      "~/Content/font-awesome.min.css",
                      "~/Content/ionicons.min.css",
                      "~/Content/AdminLTE.min.css",
                      "~/Content/_all-skins.min.css"));
            bundles.Add(new ScriptBundle("~/bundles/javascript").Include(
                       "~/Scripts/jquery-1.10.2.min.js",
                       "~/Scripts/bootstrap.min.js",
                       "~/Scripts/jquery.unobtrusive-ajax.min.js",
                       "~/Scripts/jquery.validate.unobtrusive.min.js",
                       "~/Scripts/jquery.slimscroll.min.js",
                       "~/Scripts/fastclick.js",
                       "~/Scripts/adminlte.min.js",
                       "~/Scripts/demo.js"));
        }
    }
}