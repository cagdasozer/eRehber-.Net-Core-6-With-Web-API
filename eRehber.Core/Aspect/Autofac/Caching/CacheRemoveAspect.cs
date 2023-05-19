﻿using Castle.DynamicProxy;
using eRehber.Core.Utilities.Interceptors;
using eRehber.Core.Utilities.IoC;
using eRehber.Core.CrossCuttingConcerns.Caching;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRehber.Core.Aspect.Autofac.Caching
{
	public class CacheRemoveAspect : MethodInterception
	{
		private string _pattern;
		private ICacheManager _cacheManager;

		public CacheRemoveAspect(string pattern)
		{
			_pattern = pattern;
			_cacheManager = ServiceTool.ServiceProvider.GetService<ICacheManager>();
		}

		protected override void OnSuccess(IInvocation invocation)
		{
			_cacheManager.RemoveByPattern(_pattern);
		}
	}
}
