using System.Collections.Generic;
using System.Web.Http;
using VoloteaTest.Core.Models.People;
using VoloteaTest.Core.People.ViewModels;
using VoloteaTest.Service.People;

namespace VoloteaTest.WebApi.Controllers
{
    public class PeopleController : ApiController
    {
        private IPeopleRepository _peopleRepository;
        public PeopleController() { }
        public PeopleController(IPeopleRepository peopleRepository)
        {
            _peopleRepository = peopleRepository;
        }
        // GET api/<controller>
        public IEnumerable<Person> Get()
        {
            return _peopleRepository.GetAll();
        }

        // GET api/<controller>/5
        public Person Get(int id)
        {
            return _peopleRepository.GetById(id);
        }

        // POST api/<controller>
        public void Post([FromBody] Person person)
        {
            _peopleRepository.Insert(person);
        }

        // PUT api/<controller>/5
        public void Put([FromBody] Person person)
        {
            _peopleRepository.Update(person);
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            _peopleRepository.Delete(id);
        }
    }
}