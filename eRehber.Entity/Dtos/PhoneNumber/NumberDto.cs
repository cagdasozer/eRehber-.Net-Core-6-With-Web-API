using eRehber.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRehber.Entity.Dtos.PhoneNumber
{
	public class NumberDto :IDto
	{
		public string Location { get; set; }

		public string NumberCount { get; set; }

	}
}
