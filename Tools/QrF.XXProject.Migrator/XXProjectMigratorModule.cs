using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using QrF.XXProject.EntityFramework;

namespace QrF.XXProject.Migrator
{
    [DependsOn(typeof(XXProjectDataModule))]
    public class XXProjectMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<XXProjectDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}