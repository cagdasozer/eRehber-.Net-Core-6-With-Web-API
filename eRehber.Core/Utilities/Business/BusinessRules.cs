using eRehber.Core.Utilities.Result.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRehber.Core.Utilities.Business
{
	public class BusinessRules
	{
		public static Task<IResult> Run(params Task<IResult>[] logics)
		{
			foreach (var logic in logics) 
			{
				if (!logic.Result.Success) 
				{
					return logic; 
				}
			}
			return null; 
		}
	}
}
