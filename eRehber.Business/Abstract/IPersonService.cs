using eRehber.Core.Utilities.Result.Abstract;
using eRehber.Core.Utilities.Result.Concrete;
using eRehber.Entity.Concrete;
using eRehber.Entity.Dtos.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace eRehber.Business.Abstract
{
	public interface IPersonService
	{
		Task<IDataResult<PersonListDto>> GetAllAsync();

		Task<IResult> AddAsync(PersonAddDto personAddDto);

		Task<IResult> DeleteAsync(int personId);

		Task<IResult> UpdateAsync(PersonUpdateDto personUpdateDto);
	}
}
