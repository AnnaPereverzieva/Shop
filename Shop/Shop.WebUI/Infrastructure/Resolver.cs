using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using Shop.Domain.Model;
using Shop.Domain.Repositories;


namespace Shop.WebUI.Infrastructure
{
    static public class Resolver
    {
        private static IContainer Container;
        public static T Get<T>()
        {
            return Container.Resolve<T>();
        }

        // .InstancePerDependency() — используется по умолчанию, создает новый объект при каждом вызове.
        //.InstancePerHttpRequest() -один экземпляр на HttpRequest
        //.SingleInstance() — создает только один экземпляр класса.
        //.InstancePerLifetimeScope() — создает экземпляр для конкретного LifetimeScope используеться следующим образом: 

        public static void Configure()
        {
            var builder = new ContainerBuilder();
           // builder.Register(x=>new CustomerRepository(x.Resolve<northwindEntities>())).As<IRepository<Customers>>().InstancePerLifetimeScope();
            builder.RegisterType<CustomerRepository>().As<IRepository<Customers>>().InstancePerLifetimeScope();
            //builder.RegisterGeneric(typeof(CustomerRepository)).As(typeof(IRepository<>)).InstancePerRequest();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterModule<AutofacWebTypesModule>();

            Container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(Container));

        }

    }
}