using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;
using Lay.Manage.AmazonData;
using Lay.Manage.Products.Authorization;
using Lay.Manage.Products;
using Lay.Manage.Products.Dtos;
//using Lay.Manage.Products.Dto;

namespace Lay.Manage
{
    [DependsOn(typeof(ManageCoreModule), typeof(AbpAutoMapperModule), typeof(AmazonDataModule))]
    public class ManageApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Modules.AbpAutoMapper().Configurators.Add(mapper =>
            {
                //Add your custom AutoMapper mappings here...
                //mapper.CreateMap<,>()
                //mapper.CreateMap<Products.Category, Categorylist>()
                //.ForMember(dest => dest.Text, options => options.MapFrom(t => t.Name));
                //mapper.CreateMap<Products.Product, ProductDto>();
                mapper.CreateMap<Product, ProductEditDto>()
                .ForMember(dest=>dest.Cashback,options=>options.MapFrom(t=>t.Cashback));
                mapper.CreateMap<Product, ProductListDto>()
                .ForMember(dest => dest.CashbackId, options => options.MapFrom(t => t.CashbackId)); ;

                mapper.CreateMap<ProductEditDto, Product>()
                .ForMember(dest => dest.Cashback, options => options.MapFrom(t => t.Cashback)); ;
                mapper.CreateMap<ProductListDto, Product>()
                .ForMember(dest => dest.CashbackId, options => options.MapFrom(t => t.CashbackId)); ;
            });
            Configuration.Authorization.Providers.Add<ProductAppAuthorizationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
