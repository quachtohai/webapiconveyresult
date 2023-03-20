using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using eSolution.Data;
using eSolution.Data.Infrastructure;
using eSolution.Data.Repositories;
using eSolution.Service;
using Microsoft.Owin;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

[assembly: OwinStartup(typeof(eSolution.BackendApi.App_Start.Startup))]
namespace eSolution.BackendApi.App_Start
{
       
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
            ConfigAutofac(app);           
        }
        private void ConfigAutofac(IAppBuilder app)
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            // Register your Web API controllers.
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly()); //Register WebApi Controllers

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();
            builder.RegisterType<DbFactory>().As<IDbFactory>().InstancePerRequest();

            builder.RegisterType<eSolutionDbContext>().AsSelf().InstancePerRequest();


            // Repositories
            builder.RegisterAssemblyTypes(typeof(ResultsRepository).Assembly)
                .Where(t => t.Name.EndsWith("Repository"))
                .AsImplementedInterfaces().InstancePerRequest();

            // Services
            builder.RegisterAssemblyTypes(typeof(ConveyResultsService).Assembly)
               .Where(t => t.Name.EndsWith("Service"))
               .AsImplementedInterfaces().InstancePerRequest();

            Autofac.IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver((IContainer)container); //Set the WebApi DependencyResolver

        }

    }
}