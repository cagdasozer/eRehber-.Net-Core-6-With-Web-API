using AutoMapper;
using eRehber.Core.Utilities.Result.Abstract;
using eRehber.Core.Utilities.Result.Concrete;
using eRehber.Business.Abstract;
using eRehber.Business.Constants;
using eRehber.DataAccess.Abstract;
using eRehber.Entity.Concrete;
using eRehber.Entity.Dtos.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eRehber.Core.Aspect.Autofac.Validation;
using eRehber.Business.ValidationRules.FluentValidation.Person;

namespace eRehber.Business.Concrete
{
	public class PersonManager : IPersonService
	{
		IPersonRepository _personRepository;
		IMapper _mapper;

		public PersonManager(IPersonRepository ticketRepository, IMapper mapper)
		{
			_personRepository = ticketRepository;
			_mapper = mapper;
		}

		[ValidationAspect(typeof(PersonAddValidator))]
		public async Task<IResult> AddAsync(PersonAddDto personAddDto)
		{
			var person = _mapper.Map<Person>(personAddDto);
			await _personRepository.AddAsync(person);
			await _personRepository.SaveAsync();
			return new SuccessResult(Messages.PersonAdded);
		}

		public async Task<IResult> DeleteAsync(int personId)
		{
			var person = await _personRepository.GetAsync(p => p.UUID == personId);
			if (person != null)
			{
				var deletedPerson = await _personRepository.DeleteAsync(person);
				await _personRepository.SaveAsync();
				return new SuccessResult(Messages.PersonDeleted);
			}
			else
			{
				return new ErrorResult(Messages.PersonNotFound);
			}
		}

		public async Task<IDataResult<PersonListDto>> GetAllAsync()
		{
			var persons = await _personRepository.GetAllAsync();
			if (persons != null)
			{
				return new SuccessDataResult<PersonListDto>(new PersonListDto { Persons = persons }, Messages.PersonListed);
			}
			else
			{
				return new ErrorDataResult<PersonListDto>(Messages.PersonsNotFound);
			}
		}

		[ValidationAspect(typeof(PersonUpdateValidator))]
		public async Task<IResult> UpdateAsync(PersonUpdateDto personUpdateDto)
		{
			var oldPerson = await _personRepository.GetAsync(p => p.UUID == personUpdateDto.UUID);
			var person = _mapper.Map<PersonUpdateDto, Person>(personUpdateDto, oldPerson);
			var updatePerson = await _personRepository.UpdateAsync(person);
			await _personRepository.SaveAsync();
			return new SuccessResult(Messages.PersonUpdated);
		}
	}
}
