using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.SqlClient;
using System.Web.Mvc;
using Unity;
using Unity.Injection;
using Unity.Lifetime;
using Unity.Mvc5;
using WebECom.Controllers;
using WebECom.Layers.Data;
using WebECom.Layers.Service;
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
            #region Repository

            container.RegisterType<ICategoryRepository, CategoryRepository>();

            #endregion Repository

            #region Services

            container.RegisterType<ICategoryService, CategoryService>();

            #endregion Services

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}
