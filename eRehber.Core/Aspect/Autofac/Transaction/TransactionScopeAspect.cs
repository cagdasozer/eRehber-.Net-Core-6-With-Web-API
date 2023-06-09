﻿using Castle.DynamicProxy;
using eRehber.Core.Utilities.Interceptors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace eRehber.Core.Aspect.Autofac.Transaction
{
	public class TransactionScopeAspect : MethodInterception
	{
		public override void Intercept(IInvocation invocation)
		{
			using (TransactionScope transactionScope = new TransactionScope())
			{
				try
				{
					invocation.Proceed();
					transactionScope.Complete();
				}
				catch (Exception e)
				{
					transactionScope.Dispose();
					throw;
				}
			}
		}
	}
}
