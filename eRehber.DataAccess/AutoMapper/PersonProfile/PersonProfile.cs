using AutoMapper;
using eRehber.Entity.Concrete;
using eRehber.Entity.Dtos.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace eRehber.DataAccess.AutoMapper.PersonProfile
{
	public class PersonProfile :Profile
	{
		public PersonProfile()
		{
			CreateMap<PersonAddDto, Person>();
			CreateMap<PersonUpdateDto, Person>();
			CreateMap<Person, PersonUpdateDto>();
		}
	}
}
