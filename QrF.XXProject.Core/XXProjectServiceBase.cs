using Abp;

namespace QrF.XXProject
{
    public class XXProjectServiceBase : AbpServiceBase
    {
        public XXProjectServiceBase()
        {
            LocalizationSourceName = XXProjectConsts.LocalizationSourceName;
        }
    }
}
