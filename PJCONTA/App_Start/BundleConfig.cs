using System.Web;
using System.Web.Optimization;

namespace PJCONTA
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/admin-lte/js").Include(
             "~/Scripts/AdminLTE/app.js",
             "~/Scripts/AdminLTE/plugins/fastclick.js",
             "~/Scripts/AdminLTE/plugins/bootstrap3-wysihtml5.all.min.js"
             ));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery-ui.min.js"
                        ));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      
                      "~/Content/AdminLTE/AdminLTE.min.css",
                      "~/Content/AdminLTE/skins/skin-blue.css",
                      "~/Content/AdminLTE/plugins/bootstrap3-wysihtml5.min.css"
                      ));
        }
    }
}
