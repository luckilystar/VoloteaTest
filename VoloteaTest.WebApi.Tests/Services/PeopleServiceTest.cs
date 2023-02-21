using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VoloteaTest.Core.Models.People;
using VoloteaTest.Service.People;
using System.Linq;
using VoloteaTest.Repository.People;

namespace VoloteaTest.WebApi.Tests.Services
{
    [TestClass]
    public class PeopleServiceTest
    {
        private PeopleService _peopleService;
        [TestInitialize]
        public void Setup()
        {
            _peopleService = new PeopleService(new PeopleRepository());
        }
        [TestMethod]
        public void InsertPerson()
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
            var countBefore = _peopleService.GetAll().Count();
            _peopleService.Insert(p);
            var countAfter = _peopleService.GetAll().Count();
            Assert.AreEqual(countBefore+1, countAfter);
        }

        [TestMethod]
        public void UpdatePerson()
        {
            var person = _peopleService.GetAll().FirstOrDefault();
            if (person != null)
            {
                person.Address = "This is the change of Address";
                _peopleService.Update(person);
                var personAfter = _peopleService.GetById(person.Id);
                Assert.AreEqual(personAfter.Address, person.Address);
            }
            else
            {
                Assert.Fail("There is no person data to update.");
            }
        }

        [TestMethod]
        public void DeletePerson()
        {
            var person = _peopleService.GetAll().FirstOrDefault();
            if (person != null)
            {
                _peopleService.Delete(person.Id);
                var personAfter = _peopleService.GetById(person.Id);
                Assert.IsNull(personAfter);
            }
            else
            {
                Assert.Fail("There is no person data to delete.");
            }
        }
    }
}
