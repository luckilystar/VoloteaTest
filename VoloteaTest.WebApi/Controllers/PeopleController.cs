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
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody] object person)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] object person)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}