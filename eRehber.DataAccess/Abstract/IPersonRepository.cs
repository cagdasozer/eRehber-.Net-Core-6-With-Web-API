using eRehber.Core.DataAccess.Abstract;
using eRehber.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRehber.DataAccess.Abstract
{
	public interface IPersonRepository :IEntityRepository<Person>
	{
	}
}
