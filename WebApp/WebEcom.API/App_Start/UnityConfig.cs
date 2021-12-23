using AutoMapper;
using System.Web.Http;
using Unity;
using Unity.Injection;
using Unity.Lifetime;
using Unity.WebApi;
using WebEcom.API.Controllers;
using WebECom.Models;
using WebECom.Repository;
using WebECom.Services;

namespace WebEcom.API
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            container.RegisterType<ApplicationDbContext>(new HierarchicalLifetimeManager());
            container.RegisterType<AccountController>(new InjectionConstructor());
            //container.RegisterType<ManageController>(new InjectionConstructor());

            #region AutoMapper

            MapperConfiguration config = MapperConfig.Configure(); ;
            //build the mapper
            IMapper mapper = config.CreateMapper();
            //..register mapper with the dependency container used by your application.
            container.RegisterInstance<IMapper>(mapper);

            #endregion AutoMapper

            #region Repository

            container.RegisterType<ICategoryRepository, CategoryRepository>();

            #endregion Repository

            #region Services

            container.RegisterType<ICategoryService, CategoryService>();
            container.RegisterType<IEmailSenderService, EmailSenderService>();

            #endregion Services

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}
