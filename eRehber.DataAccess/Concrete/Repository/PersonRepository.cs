using eRehber.Core.DataAccess.Concrete.EntityFramework;
using eRehber.DataAccess.Abstract;
using eRehber.Entity.Concrete;
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
	}
}
