using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;

namespace QrF.XXProject
{
    [DependsOn(typeof(XXProjectCoreModule), typeof(AbpAutoMapperModule))]
    public class XXProjectApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
