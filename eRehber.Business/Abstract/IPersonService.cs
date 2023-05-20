using eRehber.Core.Utilities.Result.Abstract;
using eRehber.Entity.Concrete;
using eRehber.Entity.Dtos.Location;
using eRehber.Entity.Dtos.Persons;
using eRehber.Entity.Dtos.PhoneNumber;
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

		Task<IDataResult<PersonDto>> GetByIdAsync(int personId);


		Task<IResult> AddAsync(PersonAddDto personAddDto);

		Task<IResult> DeleteAsync(int personId);

		Task<IResult> UpdateAsync(PersonUpdateDto personUpdateDto);


		Task<IDataResult<List<LocationDto>>> GetAllLocationCountDetails();

		Task<IDataResult<List<NumberDto>>> GetAllNumberCountDetails();

		Task<IDataResult<List<PersonCountDto>>> GetAllPersonCountDetails();
	}
}
