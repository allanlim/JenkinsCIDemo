using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustSampleTests
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TestMethodPass()
        {
            // TODO: Add test code here
            Assert.Pass("This test has passed!");
        }
        
        [Test]
        public void TestMethodIgnore()
        {
            // TODO: Add test code here
            Assert.Ignore("This test has been ignored!");
        }
        
        [Test]
        public void TestMethodInconclusive()
        {
            // TODO: Add test code here
            Assert.Inconclusive("This test was inconclusive!");
        }
    }
    public class TestClass2
    {
        [Test]
        public void TestMethodPass()
        {
            // TODO: Add test code here
            Assert.Pass("This test has passed");
        }
    }       
}
