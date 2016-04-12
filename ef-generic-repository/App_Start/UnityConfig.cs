using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using System.Data.Entity;
using Core.Context;
using Service.IService;
using Service.Service;
using Core.Repository;

namespace ef_generic_repository
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();


            //Context
            container.RegisterType<DbContext, MyDbContext>();

            //Generic Repository
            container.RegisterType(typeof(IRepository<>), typeof(GenericRepository<>));

            //Services
            container.RegisterType<IEmployeeService, EmployeeService>();

            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}