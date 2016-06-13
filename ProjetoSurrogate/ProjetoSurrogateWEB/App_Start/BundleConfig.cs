using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace ProjetoSurrogateWEB.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/css/cssBundle").Include(
                "~/Content/bootstrap.css",
                "~/Content/bootstrap-select.min.css",
                "~/Content/Site.css"
            ));

            bundles.Add(new ScriptBundle("~/jsBundle").Include(
                "~/Scripts/bootstrap.min.js",
                "~/Scripts/jquery-2.2.3.min.js",
                "~/Scripts/modernizr-2.6.2.js"
            ));

            // TODO: mudar isso para true antes de implantar em produção
            BundleTable.EnableOptimizations = true;
        }
    }
}