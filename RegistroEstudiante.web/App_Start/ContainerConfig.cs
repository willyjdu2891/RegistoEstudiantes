using Autofac;
using Autofac.Integration.Mvc;
using RegistroEstudiante.data.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegistroEstudiante.web
{
   internal class ContainerConfig
    {
        internal static void ResolveDependencies()
        {

            //var builder = new ContainerBuilder();

            //builder.RegisterControllers(typeof(MvcApplication).Assembly);

            //builder.RegisterType<EstudianteServiceTest>().As<IEstudiantesService>().SingleInstance();
            //builder.RegisterType<CursoServiceTest>().As<ICursosService>().SingleInstance();

            //var container = builder.Build();
            //DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}