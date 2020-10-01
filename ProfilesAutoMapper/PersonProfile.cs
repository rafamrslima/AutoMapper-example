
using AutoMapper;
using automapper_test.Domain;
using automapper_test.Dtos;

namespace automapper_test.ProfilesAutoMapper
{
    public class PersonProfile: Profile
    {
       public PersonProfile()
       {
           CreateMap<PersonDto, Person>();
           CreateMap<Person, PersonDto>();
       }
    }
}
