using System.Collections.Generic;
using System.Web.Http;
using VoloteaTest.Core.Models.People;
using VoloteaTest.Repository.People;
using VoloteaTest.Service.People;

namespace VoloteaTest.WebApi.Controllers
{
    public class PeopleController : ApiController
    {
        private IPeopleService _peopleService;
        public PeopleController() { }
        public PeopleController(IPeopleService peopleService)
        {
            _peopleService = peopleService;
        }
        // GET api/<controller>
        public IEnumerable<Person> Get()
        {
            return _peopleService.GetAll();
        }

        // GET api/<controller>/5
        public Person Get(int id)
        {
            return _peopleService.GetById(id);
        }

        // POST api/<controller>
        public void Post([FromBody] Person person)
        {
            _peopleService.Insert(person);
        }

        // PUT api/<controller>/5
        public void Put([FromBody] Person person)
        {
            _peopleService.Update(person);
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            _peopleService.Delete(id);
        }
    }
}