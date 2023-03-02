using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FirstUnitTestProject {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void TestMethod1() {
            // the reference to the project must be added

            bool result = Testing.Program.EsPrimo(23);

            Assert.AreEqual(true,result);
        }
    }
}
