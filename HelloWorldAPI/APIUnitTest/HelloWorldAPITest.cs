using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld.Controllers;
namespace APIUnitTest
{
    [TestClass]
    public class HelloWorldAPITest
    {
        [TestMethod]
        public void StringValidation()
        {
            var controller = new HelloController();
            var result = controller.Get();
            Assert.AreEqual("Hello World", result);
        }
    }
}
