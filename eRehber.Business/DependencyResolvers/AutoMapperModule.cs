using eRehber.Core.Utilities.IoC;
using eRehber.DataAccess.AutoMapper.PersonProfile;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRehber.Business.DependencyResolvers
{
	public class AutoMapperModule : ICoreModule
	{
		public void Load(IServiceCollection serviceCollection)
		{
			serviceCollection.AddAutoMapper(typeof(PersonProfile));
		}
	}
}
