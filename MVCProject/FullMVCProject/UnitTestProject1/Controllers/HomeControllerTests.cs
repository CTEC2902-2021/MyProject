using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVCProject.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;



namespace MVCProject.Controllers.Tests
{
    [TestClass()]
    public class HomeControllerTests
    {
        [TestMethod()]
        public void AboutTest()
        {
            // Arrange
            HomeController controller = new HomeController();
            // Act
      //      ViewResult result = controller.About() as ViewResult;
            // Assert
        //    Assert.AreEqual("Your application description page.", result.ViewBag.Message);
            Assert.Fail();
        }
    }
}