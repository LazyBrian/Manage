using Abp.Web.Mvc.Views;

namespace Lay.Manage.Web.Views
{
    public abstract class ManageWebViewPageBase : ManageWebViewPageBase<dynamic>
    {

    }

    public abstract class ManageWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected ManageWebViewPageBase()
        {
            LocalizationSourceName = ManageConsts.LocalizationSourceName;
        }
    }
}