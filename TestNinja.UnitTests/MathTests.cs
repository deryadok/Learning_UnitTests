using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestClass]
    public class MathTests
    {
        private Math _math;

        //[TestCleanup] -> For deleting some data that saved in tests.
        [TestInitialize]
        public void SetUp()
        {
            _math = new Math();
        }

        [TestMethod]
        [Ignore]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            var result = _math.Add(1, 2);

            Assert.AreEqual(result, 3);
        }

        [TestMethod]
        [DataRow(2, 1, 2)]
        [DataRow(1, 2, 2)]
        [DataRow(1, 1, 1)]
        public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expectedResult)
        {
            var result = _math.Max(a, b);

            Assert.AreEqual(result, expectedResult);
        }

        //[TestMethod]
        //public void Max_FirstArgumentIsGreater_ReturnTheFirstArgument()
        //{
        //    var result = _math.Max(2, 1);

        //    Assert.AreEqual(result, 2);
        //}

        //[TestMethod]
        //public void Max_SecondArgumentIsGreater_ReturnTheSecondArgument()
        //{

        //    var result = _math.Max(1, 2);

        //    Assert.AreEqual(result, 2);
        //}

        //[TestMethod]
        //public void Max_ArgumentsAreEqual_ReturnTheSameArgument()
        //{
        //    var result = _math.Max(2, 2);

        //    Assert.AreEqual(result, 2);
        //}
    }
}
