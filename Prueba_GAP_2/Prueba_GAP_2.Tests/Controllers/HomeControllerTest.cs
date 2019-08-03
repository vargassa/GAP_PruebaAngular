using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prueba_GAP_2;
using Prueba_GAP_2.Controllers;

namespace Prueba_GAP_2.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Disponer
            HomeController controller = new HomeController();

            // Actuar
            ViewResult result = controller.Index() as ViewResult;

            // Declarar
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
