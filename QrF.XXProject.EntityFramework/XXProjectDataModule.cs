using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using QrF.XXProject.EntityFramework;

namespace QrF.XXProject
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(XXProjectCoreModule))]
    public class XXProjectDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<XXProjectDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
