using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc3;
using dependency2.Iinterface;
using dependency2.Repository;
using dependency2.Models;
using dependency2.Services;

namespace dependency2
{
    public static class Bootstrapper
    {
        public static void Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();            
            container.RegisterType<IUnitOfWork, UnitOfWork>();
            container.RegisterType<IRepository<officer>, officerRepository>();
            container.RegisterType<IOfficerService, OfficerService>();
            return container;
        }
    }
}