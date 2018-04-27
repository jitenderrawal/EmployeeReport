using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace EmployeeAttendance
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<EmployeeAttendance.Models.Interfaces.IEmployeeRepository, EmployeeAttendance.Models.Repositories.EmployeeRepository>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}