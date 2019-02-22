using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Travel_Content_Management_Editor;
using Travel_Content_Management_Editor.Controllers;

namespace Travel_Content_Management_Editor.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Places()
        {
            // Arrange
            PlacesController controller = new PlacesController();

            // Act
            ViewResult result = controller.Places() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Events()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Events() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
