﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using VoloteaTest.WebApi.Controllers;

namespace VoloteaTest.WebApi.Tests.Controllers
{
    [TestClass]
    public class PeopleControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            PeopleController controller = new PeopleController();

            // Act
            IEnumerable<string> result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
            Assert.AreEqual("value1", result.ElementAt(0));
            Assert.AreEqual("value2", result.ElementAt(1));
        }

        [TestMethod]
        public void GetById()
        {
            // Arrange
            PeopleController controller = new PeopleController();

            // Act
            string result = controller.Get(5);

            // Assert
            Assert.AreEqual("value", result);
        }

        [TestMethod]
        public void Post()
        {
            // Arrange
            PeopleController controller = new PeopleController();

            // Act
            controller.Post("value");

            // Assert
        }

        [TestMethod]
        public void Put()
        {
            // Arrange
            PeopleController controller = new PeopleController();

            // Act
            controller.Put(5, "value");

            // Assert
        }

        [TestMethod]
        public void Delete()
        {
            // Arrange
            PeopleController controller = new PeopleController();

            // Act
            controller.Delete(5);

            // Assert
        }
    }
}
