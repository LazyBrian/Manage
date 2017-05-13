using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Lay.Manage.EntityFramework;

namespace Lay.Manage.Migrator
{
    [DependsOn(typeof(ManageDataModule))]
    public class ManageMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<ManageDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}