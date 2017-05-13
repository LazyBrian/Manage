using System.Reflection;
using System.Web.Http;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.WebApi;
using Swashbuckle.Application;
using System.Linq;

namespace Lay.Manage.Api
{
    [DependsOn(typeof(AbpWebApiModule), typeof(ManageApplicationModule))]
    public class ManageWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(ManageApplicationModule).Assembly, "app")
                .Build();
            Configuration.Modules.AbpWeb().AntiForgery.IsEnabled = false;
            Configuration.Modules.AbpWebApi().HttpConfiguration.Filters.Add(new HostAuthenticationFilter("Bearer"));
            ConfigureSwaggerUi();
        }
        private void ConfigureSwaggerUi()
        {
            Configuration.Modules.AbpWebApi().HttpConfiguration
                .EnableSwagger(c =>
                {
                    c.SingleApiVersion("V1", "Manage Swagger");
                    c.ResolveConflictingActions(apiDesc => apiDesc.First());
                })
                .EnableSwaggerUi();
        }
    }
}
