using System.Web;
using System.Web.Optimization;

namespace turismo
{
    public class BundleConfig
    {
        // Para obtener más información acerca de Bundling, consulte http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/SystemCSS").Include(
                "~/Content/assets/css/style.css",
                 "~/Content/assets/css/bootstrap.css",
                "~/Content/assets/css/bootstrap-responsive.css",
                "~/Content/assets/js/fancybox/jquery.fancybox-1.3.4.css",
                "~/Content/assets/css/brickSlide.css",
                "~/Content/assets/css/responsive.css"
               
                
            ));
            bundles.Add(new ScriptBundle("~/SystemJS").Include(
               "~/Content/assets/js/jquery-1.7.1.min.js",
                "~/Content/assets/js/plugins.js",
                "~/Content/assets/js/bootstrap-dropdown.js",
                "~/Content/assets/js/bootstrap-scrollspy.js",
                "~/Content/assets/js/bootstrap-tab.js",
                "~/Content/assets/js/bootstrap-collapse.js",
                "~/Content/assets/js/fancybox/jquery.fancybox-1.3.4.pack.js",
                "~/Content/assets/js/form-validation.js",
                 "~/Content/assets/js/custom.js",
                "~/Content/assets/js/modernizr-2.5.3.min.js",
                "~/Content/assets/js/brickSlide.js",
                "~/Content/assets/js/jquery.masonry.min.js"
                
            ));
            bundles.IgnoreList.Clear();

        }
    }
}