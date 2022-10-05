using API_Interactive_Lab_1.Controllers;
using NUnit.Framework;
using API_Interactive_Lab_1.Models;

namespace API_Interactive_Lab_1.Tests.Controllers
{
    public class CoffeeControllerTests
    {
        [Test]
        public void Test_Get_Coffee_Lover_Endpoint()
        {

            string expectedContent = "I like coffee!";

            var controller = new CoffeeController();
            var result = controller.Get();
            Assert.AreEqual(expectedContent, result);
        }

        [Test]
        public void Test_Get_Latte()
        {
            Coffee expected = new Coffee { Name = "latte", Id = -1 };

            var controller = new CoffeeController();
            var result = controller.Get(null);
            Assert.AreEqual(expected.Name, result.Name);
            Assert.AreEqual(expected.Id, result.Id);
        }

        [Test]
        public void Test_Get_Cappuccino()
        {
            Coffee expected = new Coffee { Name = "cappuccino", Id = 3 };

            var controller = new CoffeeController();
            var result = controller.Get("cappuccino");
            Assert.AreEqual(expected.Name, result.Name);
            Assert.AreEqual(expected.Id, result.Id);
        }
    }
}
