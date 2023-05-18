using eRehber.Core.Entities.Abstract;
using eRehber.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRehber.Entity.Dtos.Persons
{
	public class PersonListDto :IDto
	{
        public List<Person> Persons { get; set; }
    }
}
