using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace VoloteaTest.Service
{
    public class ServiceModule:Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(Assembly.Load("VoloteaTest.Service"))
                   .Where(t => t.Name.EndsWith("Service"))
                   .AsImplementedInterfaces()
                  .InstancePerLifetimeScope();
        }
    }
}
