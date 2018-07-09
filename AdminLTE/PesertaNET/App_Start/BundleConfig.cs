using System.Web.Optimization;
using WebHelpers.Mvc5;

namespace PesertaNET
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Bundles/css")
                .Include("~/Content/User/css/bootstrap.min.css", new CssRewriteUrlTransformAbsolute())
                .Include("~/Content/User/css/bootstrap-select.css")
                .Include("~/Content/User/css/bootstrap-datepicker3.min.css")
                .Include("~/Content/User/css/font-awesome.min.css", new CssRewriteUrlTransformAbsolute())
                .Include("~/Content/User/css/icheck/blue.min.css", new CssRewriteUrlTransformAbsolute())
                .Include("~/Content/User/css/AdminLTE.css", new CssRewriteUrlTransformAbsolute())
                .Include("~/Content/User/css/skins/skin-blue.css"));

            bundles.Add(new ScriptBundle("~/Bundles/js")
                .Include("~/Content/User/js/plugins/jquery/jquery-3.3.1.js")
                .Include("~/Content/User/js/plugins/bootstrap/bootstrap.js")
                .Include("~/Content/User/js/plugins/fastclick/fastclick.js")
                .Include("~/Content/User/js/plugins/slimscroll/jquery.slimscroll.js")
                .Include("~/Content/User/js/plugins/bootstrap-select/bootstrap-select.js")
                .Include("~/Content/User/js/plugins/moment/moment.js")
                .Include("~/Content/User/js/plugins/datepicker/bootstrap-datepicker.js")
                .Include("~/Content/User/js/plugins/icheck/icheck.js")
                .Include("~/Content/User/js/plugins/validator.js")
                .Include("~/Content/User/js/plugins/inputmask/jquery.inputmask.bundle.js")
                .Include("~/Content/User/js/adminlte.js")
                .Include("~/Content/User/js/init.js"));

#if DEBUG
            BundleTable.EnableOptimizations = false;
#else
            BundleTable.EnableOptimizations = true;
#endif
        }
    }
}
