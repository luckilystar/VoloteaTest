using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using VoloteaTest.Core.Models.People;
using VoloteaTest.WebApi.Controllers;

namespace VoloteaTest.WebApi.Tests.Controllers
{
    [TestClass]
    public class PeopleControllerTest
    {
        private PeopleController _controller;
        [TestInitialize]
        public void Setup()
        {
            _controller = new PeopleController(new Service.People.PeopleService(new Repository.People.PeopleRepository()));
        }
        [TestMethod]
        public void Get()
        {
            IEnumerable<Person> result = _controller.Get();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetById()
        {
            var person = _controller.Get().FirstOrDefault();
            if (person != null)
            {
                var result = _controller.Get(person.Id);
                Assert.AreEqual(person, result);
            }
            else
                Assert.Fail("There is no data to get.");
        }

        [TestMethod]
        public void Post()
        {
            Person p = new Person
            {
                Address = "Address 1",
                Birthday = DateTime.Today.AddYears(-19),
                Email = "address@gmail.com",
                FirstName = "Name 1",
                LastName = "Last Name 1",
                PhoneNumber = "12345678"
            };

            var countBefore = _controller.Get().Count();
            _controller.Post(p);
            var countAfter = _controller.Get().Count();

            Assert.AreEqual(countBefore + 1, countAfter);
        }

        [TestMethod]
        public void Put()
        {
            var person = _controller.Get().FirstOrDefault();
            if (person != null)
            {
                person.Address = "Change To New Address";
                _controller.Put(person);
                var personAfter = _controller.Get(person.Id);
                Assert.AreEqual(person.Address, personAfter.Address);
            }
            else
                Assert.Fail("There is no data to update.");
        }

        [TestMethod]
        public void Delete()
        {
            var person = _controller.Get().FirstOrDefault();
            if (person != null)
            {
                _controller.Delete(person.Id);
                var result = _controller.Get(person.Id);
                Assert.IsNull(result);
            }
            else
                Assert.Fail("There is no data to delete.");
        }
    }
}
