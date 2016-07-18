using Abp.Web.Mvc.Views;

namespace QrF.XXProject.Web.Views
{
    public abstract class XXProjectWebViewPageBase : XXProjectWebViewPageBase<dynamic>
    {

    }

    public abstract class XXProjectWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected XXProjectWebViewPageBase()
        {
            LocalizationSourceName = XXProjectConsts.LocalizationSourceName;
        }
    }
}