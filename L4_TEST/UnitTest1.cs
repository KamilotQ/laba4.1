using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace L4_TEST
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            L4.Student ex = new L4.Student();
            int r = 50;
            string result = ex.StudentRating(r);
            Assert.AreEqual("Pay more attention to studying.", result);
        }
    }
}
