using eRehber.Core.DataAccess.Abstract;
using eRehber.Entity.Concrete;
using eRehber.Entity.Dtos.Location;
using eRehber.Entity.Dtos.Persons;
using eRehber.Entity.Dtos.PhoneNumber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRehber.DataAccess.Abstract
{
	public interface IPersonRepository :IEntityRepository<Person>
	{
		Task<List<LocationDto>> GetLocationCountDetails();

		Task<List<NumberDto>> GetNumberCountLocations();

		Task<List<PersonCountDto>> GetAllPersonLocation();
	}
}
