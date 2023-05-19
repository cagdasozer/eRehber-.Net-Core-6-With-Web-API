using AutoMapper;
using eRehber.Business.Abstract;
using eRehber.Entity.Dtos.Persons;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Sockets;

namespace eRehber.WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PersonsController : ControllerBase
	{
		private readonly IPersonService _personService;
		private readonly IMapper _mapper;

		public PersonsController(IPersonService personService, IMapper mapper)
		{
			_personService = personService;
			_mapper = mapper;
		}

		[HttpGet("getall")]
		public async Task<IActionResult> GetAllAsync() 
		{
			var result = await _personService.GetAllAsync();
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest();
		}

		[HttpPost("add")]
		public async Task<IActionResult> AddAsync(PersonAddDto ticket)
		{
			var result = await _personService.AddAsync(ticket);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}

		[HttpPut("update")]
		public async Task<IActionResult> UpdateAsync(PersonUpdateDto person)
		{
			var result = await _personService.UpdateAsync(person);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}

		[HttpDelete("delete")]
		public async Task<IActionResult> DeleteAsync(int personId)
		{
			var result = await _personService.DeleteAsync(personId);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}
	}
}
