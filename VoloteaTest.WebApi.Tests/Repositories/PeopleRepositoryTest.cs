using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VoloteaTest.Core.Models.People;
using System.Linq;
using VoloteaTest.Repository.People;

namespace VoloteaTest.WebApi.Tests.Repositories
{
    [TestClass]
    public class PeopleRepositoryTest
    {
        private PeopleRepository _peopleRepository;
        [TestInitialize]
        public void Setup()
        {
            _peopleRepository = new PeopleRepository();
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
            var countBefore = _peopleRepository.GetAll().Count();
            _peopleRepository.Insert(p);
            _peopleRepository.Save();
            var countAfter = _peopleRepository.GetAll().Count();
            Assert.AreEqual(countBefore+1, countAfter);
        }

        [TestMethod]
        public void UpdatePerson()
        {
            var person = _peopleRepository.GetAll().FirstOrDefault();
            if (person != null)
            {
                person.Address = "This is the change of Address";
                _peopleRepository.Update(person);
                _peopleRepository.Save();
                var personAfter = _peopleRepository.GetById(person.Id);
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
            var person = _peopleRepository.GetAll().FirstOrDefault();
            if (person != null)
            {
                _peopleRepository.Delete(person.Id);
                _peopleRepository.Save();
                var personAfter = _peopleRepository.GetById(person.Id);
                Assert.IsNull(personAfter);
            }
            else
            {
                Assert.Fail("There is no person data to delete.");
            }
        }
    }
}
