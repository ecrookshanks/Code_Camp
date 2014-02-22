using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnityMVC_DepResolver;
using UnityMVC_DepResolver.Controllers;

using Microsoft.Practices.Unity;

namespace UnityMVC_DepResolver.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        private UnityContainer container = null;

        [TestInitialize]
        public void TestSetup()
        {
            container = new UnityContainer();
            container.RegisterType<ISomeContent, SomeTestContent>();
        }

        [TestMethod]
        public void Index()
        {
            // Arrange - using constructor injection
            ISomeContent sc = container.Resolve<ISomeContent>();
            HomeController controller = new HomeController(sc);

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.AreEqual("Test Content", result.ViewBag.Message);
        }

        //[TestMethod]
        //public void About()
        //{
        //    // Arrange - using property injection
        //    HomeController controller = new HomeController();
        //    controller.someContent = container.Resolve<ISomeContent>();

        //    // Act
        //    ViewResult result = controller.About() as ViewResult;

        //    // Assert
        //    Assert.IsNotNull(result);
        //    Assert.AreEqual("Test Help-About Content", result.ViewBag.Message);
        //}
    }
}
