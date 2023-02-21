using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoloteaTest.EF
{
    public class EFModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //builder.RegisterModule(new RepositoryModule());
            builder.RegisterType(typeof(PeopleDbContext))
                .As(typeof(System.Data.Entity.DbContext))
                .InstancePerLifetimeScope();
        }

    }
}
