using eRehber.Business.Constants;
using eRehber.Entity.Dtos.Persons;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRehber.Business.ValidationRules.FluentValidation.Person
{
	public class PersonUpdateValidator : AbstractValidator<PersonUpdateDto>
	{
		public PersonUpdateValidator()
		{
			RuleFor(p => p.FirstName).NotEmpty().WithMessage(Messages.FirstNameNotEmpty);
			RuleFor(p => p.FirstName).NotNull();
			RuleFor(p => p.FirstName).MaximumLength(30).WithMessage(Messages.FirstNameMaxLenght);
			RuleFor(p => p.LastName).NotEmpty().WithMessage(Messages.LastNameNotEmpty);
			RuleFor(p => p.LastName).NotNull();
			RuleFor(p => p.LastName).MaximumLength(30).WithMessage(Messages.LastNameMaxLenght);
			RuleFor(p => p.Company).NotEmpty().WithMessage(Messages.CompanyNotEmpty);
			RuleFor(p => p.Company).NotNull();
			RuleFor(p => p.PhoneNumber).NotNull();
			RuleFor(p => p.PhoneNumber).NotEmpty().WithMessage(Messages.PhoneNumberNotEmpty);
			RuleFor(p => p.EMail).NotNull();
			RuleFor(p => p.EMail).NotEmpty().WithMessage(Messages.EMailNotEmpty);
			RuleFor(p => p.Location).NotEmpty().WithMessage(Messages.LocationNotEmpty);
			RuleFor(p => p.Location).NotNull();
		}
	}
}
