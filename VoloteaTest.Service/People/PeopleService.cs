using VoloteaTest.Core.Models.People;
using VoloteaTest.Repository.People;

namespace VoloteaTest.Service.People
{
    public class PeopleService : GenericService<Person>, IPeopleService
    {
        public IPeopleRepository _peopleRepository;
        public PeopleService(IPeopleRepository peopleRepository)
            : base(peopleRepository)
        {
            _peopleRepository = peopleRepository;
        }
    }
}
