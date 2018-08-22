using Castle.DynamicProxy;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using ConsoleApp.Interception;
using SimpleCalculator;
using SimpleLogger;

namespace ConsoleApp.DI
{
    public static class DependencyInjection
    {
        public static WindsorContainer CreateContainer()
        {
            var container = new WindsorContainer();

            // Main classes
            container.Register(Component.For<ILogger>().ImplementedBy<Logger>());
            container.Register(Component.For<IApp>().ImplementedBy<App>());

            // Interceptors
            // Declaring interceptor at registration (manually), although it can be done automatically as well
            container.Register(Component.For<IInterceptor>().ImplementedBy<LoggingInterceptor>());
            container.Register(Component.For<ICalculator>().ImplementedBy<InterceptedCalculator>().Interceptors<LoggingInterceptor>());

            return container;
        }

        public static BasedOnDescriptor GetClassesToIntercept()
        {
            return Classes.FromAssembly(typeof(InterceptedCalculator).Assembly).BasedOn<ICalculator>();
        }

        /// <summary>
        ///  Get all public classes in this assembly with their first interface.
        ///  A quick, albeit dirty, way of registering all dependencies we're interested in. 
        /// </summary>
        public static BasedOnDescriptor GetAllPublicClassesInAssembly()
        {
            return Classes.FromThisAssembly()
                    .Where(type => type.IsPublic)
                    .WithService
                    .FirstInterface();
        }
    }
}
