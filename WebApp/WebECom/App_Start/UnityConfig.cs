using AutoMapper;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.SqlClient;
using System.Web.Mvc;
using Unity;
using Unity.Injection;
using Unity.Lifetime;
using Unity.Mvc5;
using WebECom.App_Start;
using WebECom.Controllers;
using WebECom.Repository;
using WebECom.Services;
using WebECom.Models;

namespace WebECom
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            container.RegisterType<ApplicationDbContext>(new HierarchicalLifetimeManager());
            container.RegisterType<AccountController>(new InjectionConstructor());
            container.RegisterType<ManageController>(new InjectionConstructor());

            #region AutoMapper

            MapperConfiguration config = MapperConfig.Configure(); ;
            //build the mapper
            IMapper mapper = config.CreateMapper();
            //..register mapper with the dependency container used by your application.
            container.RegisterInstance<IMapper>(mapper);

            #endregion AutoMapper

            #region Repository

            container.RegisterType<ICategoryRepository, CategoryRepository>();
            container.RegisterType<IProductRepository, ProductRepository>();

            #endregion Repository

            #region Services

            container.RegisterType<ICategoryService, CategoryService>();
            container.RegisterType<IEmailSenderService, EmailSenderService>();
            container.RegisterType<IProductService, ProductService>();

            #endregion Services

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}
