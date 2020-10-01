using System.Collections.Generic;
using AutoMapper;
using automapper_test.Domain;
using automapper_test.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace automapper_test.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PeopleController : ControllerBase
    {
        private IMapper _iMapper;
        public PeopleController(IMapper iMapper)
        {
            _iMapper = iMapper;
        }

        [HttpPost]
        public IActionResult Post(PersonDto personDto)
        {
            var person = _iMapper.Map<Person>(personDto);
            return Ok(person);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var people = new List<Person>()
            {
                new Person("John", "Jackson", "555555555"),
                new Person("Michael", "Johnson", "555555") 
            };
            var peopleDto = _iMapper.Map<List<Person>, List<PersonDto>>(people);
            return Ok(peopleDto);
        }

        [HttpGet("{phoneNumber}")]
        public IActionResult GetByPhoneNumber(string phoneNumber)
        {
            var person = new Person("John", "Jackson", phoneNumber);
            var personDto = _iMapper.Map<PersonDto>(person);
            return Ok(personDto);
        }
    }
}