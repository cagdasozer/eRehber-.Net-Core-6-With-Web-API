using Castle.DynamicProxy;
using eRehber.Core.Utilities.Interceptors;
using eRehber.Core.Utilities.Messages;
using eRehber.Core.CrossCuttingConcerns.Validation;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace eRehber.Core.Aspect.Autofac.Validation
{
	public class ValidationAspect : MethodInterception
	{
		private Type _validatorType;
		public ValidationAspect(Type validatorType)
		{
			if (!typeof(IValidator).IsAssignableFrom(validatorType))
			{
				throw new Exception(AspectMessages.WrongValidationType);
			}

			_validatorType = validatorType;
		}
		protected override void OnBefore(IInvocation invocation)
		{
			var validator = (IValidator)Activator.CreateInstance(_validatorType);
			var entityType = _validatorType.BaseType.GetGenericArguments()[0];
			var entities = invocation.Arguments.Where(t => t.GetType() == entityType);
			foreach (var entity in entities)
			{
				ValidationTool.Validate(validator, entity);
			}
		}
	}
}
