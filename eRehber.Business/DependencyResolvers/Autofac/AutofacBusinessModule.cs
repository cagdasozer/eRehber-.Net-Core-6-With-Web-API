using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using eRehber.Core.Utilities.Interceptors;
using eRehber.Business.Abstract;
using eRehber.Business.Concrete;
using eRehber.DataAccess.Abstract;
using eRehber.DataAccess.Concrete.Context;
using eRehber.DataAccess.Concrete.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRehber.Business.DependencyResolvers.Autofac
{
	public class AutofacBusinessModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterType<eRehberContext>().As<DbContext>().SingleInstance();

			builder.RegisterType<PersonManager>().As<IPersonService>().SingleInstance();
			builder.RegisterType<PersonRepository>().As<IPersonRepository>().SingleInstance();

		

			var assembly = System.Reflection.Assembly.GetExecutingAssembly();

			builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
				.EnableInterfaceInterceptors(new ProxyGenerationOptions()
				{
					Selector = new AspectInterceptorSelector()
				}).SingleInstance();
		}
	}
}
