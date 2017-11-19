using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IdentificationNoCheckDigit;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class Test_CheckDigit
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<TestCase> testCaseList = new List<TestCase>();
            testCaseList.Add(new TestCase() { IdCard = 110040062874 });
            foreach (TestCase testCase in testCaseList)
            {
                CheckDigit checkDigit = new CheckDigit();
                int output = checkDigit.CalLastID(testCase.IdCard);
                int checkOutput = Convert.ToInt32(testCase.IdCard.ToString().Substring(12, 1));
                Assert.AreEqual(checkOutput, output);
            }
        }
    }
    public class TestCase {
        public long IdCard { get; set; }
    }
}
