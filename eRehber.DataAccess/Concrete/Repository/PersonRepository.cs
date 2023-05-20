using eRehber.Core.DataAccess.Concrete.EntityFramework;
using eRehber.DataAccess.Abstract;
using eRehber.DataAccess.Concrete.Context;
using eRehber.Entity.Concrete;
using eRehber.Entity.Dtos.Location;
using eRehber.Entity.Dtos.Persons;
using eRehber.Entity.Dtos.PhoneNumber;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRehber.DataAccess.Concrete.Repository
{
	public class PersonRepository : BaseEntityRepository<Person>, IPersonRepository
	{
		public PersonRepository(DbContext context) : base(context)
		{
		}

		public async Task<List<LocationDto>> GetLocationCountDetails()
		{
			using (eRehberContext context = new eRehberContext())
			{
				var result = from p in context.Persons.GroupBy(p => p.Location).OrderByDescending(p=>p.Count())
							 select new LocationDto
							 {
								 LocationCount = p.Count().ToString(),
								 Location = p.First().Location
							 };
				return result.ToList();
			}
		}

		public async Task<List<NumberDto>> GetNumberCountLocations()
		{
			using (eRehberContext context = new eRehberContext())
			{
				var result = from p in context.Persons.GroupBy(p => p.Location)
							 select new NumberDto
							 {
								 Location = p.First().Location,
								 NumberCount = p.Count().ToString(),
							 };
				return result.ToList();
			}
		}

		public async Task<List<PersonCountDto>> GetAllPersonLocation()
		{
			using (eRehberContext context = new eRehberContext())
			{
				var result = from p in context.Persons.GroupBy(p => p.Location)
							 select new PersonCountDto
							 {
								 Location = p.First().Location,
								 PersonCount = p.Count().ToString(),

							 };
				return result.ToList();
			}
		}

	}
}
