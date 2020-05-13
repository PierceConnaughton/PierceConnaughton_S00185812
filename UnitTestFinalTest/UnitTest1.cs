using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinalTest;

namespace UnitTestFinalTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IncreasePriceTest()
        {
            //Tests if the IncreasePrice method for phone works

            //ARRANGE
            Phone p1 = new Phone();
            p1.Price = 100;

            int percentage = 10;

            int expectedResult = 110;

            //ACT
            p1.IncreasePrice(percentage);

            //ASSERT
            Assert.AreEqual(expectedResult, p1.Price);


        }
    }
}
