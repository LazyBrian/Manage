using System.Web.Optimization;

namespace Lay.Manage.Web
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.IgnoreList.Clear();

            bundles.Add(new StyleBundle("~/Bundles/css")
              .Include("~/Content/css/bootstrap.css")
              .Include("~/Content/css/select2.css")
              .Include("~/Content/css/datepicker3.css")
              
              .Include("~/Content/font-awesome.min.css", new CssRewriteUrlTransform())
              .Include("~/Content/ionicons/ionicons.min.css", new CssRewriteUrlTransform())
              .Include("~/Scripts/sweetalert/sweet-alert.css", new CssRewriteUrlTransform())

              .Include("~/Content/css/AdminLTE.css")
              .Include("~/Content/css/skins/skin-blue.css")

              .Include("~/css/main.css"));

            bundles.Add(new ScriptBundle("~/Bundles/js")
                .Include("~/Content/js/plugins/jquery/jquery-2.2.4.js")
                .Include("~/Content/js/plugins/bootstrap/bootstrap.js")
                .Include("~/Content/js/plugins/fastclick/fastclick.js")
                .Include("~/Content/js/plugins/slimscroll/jquery.slimscroll.js")
                .Include("~/Content/js/plugins/select2/select2.full.js")
                .Include("~/Content/js/plugins/moment/moment.js")
                .Include("~/Content/js/plugins/datepicker/bootstrap-datepicker.js")
                .Include("~/Content/js/plugins/icheck/icheck.js")
                .Include("~/Content/js/plugins/validator.js")
                .Include("~/Content/js/plugins/inputmask/jquery.inputmask.bundle.js")
                
                .Include(
                        "~/Scripts/toastr.min.js",
                        "~/Scripts/jquery.blockUI.js",
                        "~/Scripts/sweetalert/sweet-alert.min.js",

                        "~/Abp/Framework/scripts/abp.js",
                        "~/Abp/Framework/scripts/libs/abp.jquery.js",
                        "~/Abp/Framework/scripts/libs/abp.toastr.js",
                        "~/Abp/Framework/scripts/libs/abp.blockUI.js",
                        "~/Abp/Framework/scripts/libs/abp.spin.js",
                        "~/Abp/Framework/scripts/libs/abp.sweet-alert.js",
                        "~/Abp/Framework/scripts/libs/abp.moment.js",

                        "~/Scripts/jquery.signalR-2.2.1.min.js")
                .Include("~/Content/js/app.js")
                .Include("~/Content/js/init.js")
                .Include("~/js/main.js")
                );
            
            //~/Bundles/vendor/js/top (These scripts should be included in the head of the page)
            bundles.Add(
                new ScriptBundle("~/Bundles/vendor/js/top")
                    .Include(
                        "~/Abp/Framework/scripts/utils/ie10fix.js",
                        "~/Scripts/modernizr-2.8.3.js"
                    )
                );
            
        }
    }
}