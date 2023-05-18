using eRehber.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRehber.Entity.Concrete
{
	public class Person : IEntity
	{
		public int UUID { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

        public string Company { get; set; }

        public string PhoneNumber { get; set; }

        public string EMail { get; set; }

        public string Location { get; set; }

        public string InformationContent { get; set; }


    }
}
