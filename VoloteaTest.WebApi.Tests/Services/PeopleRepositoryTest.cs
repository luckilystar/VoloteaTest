using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VoloteaTest.Service.People;

namespace VoloteaTest.WebApi.Tests.Services
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
        public void TestMethod1()
        {
        }
    }
}
