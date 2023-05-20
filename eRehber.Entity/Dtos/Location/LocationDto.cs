using eRehber.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRehber.Entity.Dtos.Location
{
	public class LocationDto :IDto
	{
		public string Location { get; set; }

        public string LocationCount { get; set; }

	}
}
