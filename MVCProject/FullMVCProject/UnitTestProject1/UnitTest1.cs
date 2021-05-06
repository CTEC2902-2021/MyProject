using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVCProject.Controllers;
using System.Web;
// using System.Web.Mvc;



namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            HomeController controller = new HomeController();
            // Act
          //  ViewResult result = controller.About() as ViewResult;
            // Assert
          //  Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }
    }
}
