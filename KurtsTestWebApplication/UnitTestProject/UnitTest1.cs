using KurtsTestWebApplication.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            HomeController controller = new HomeController(null);

            // Act
            IActionResult result = controller.Index() as IActionResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            HomeController controller = new HomeController(null);

            // Act
            IActionResult result = controller.Privacy() as IActionResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
