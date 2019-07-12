using LCodeExperiments.Algorithms;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCodeExperimentTests.Algorithms
{
    [TestFixture()]
    public class DivihsaExpTest
    {
        public DivishaExp DhivishaExp { get; set; }
        [OneTimeSetUp()]
        public void Setup()
        {
            DhivishaExp = new DivishaExp();
        }

        [Test()]
        public void LongestSubStringTest_1()
        {
            var testval = "My Name is Dhivisha";
            var testChar = 'h';
            var expectedVal = 2;

            var returnedVal = DhivishaExp.findCharCountInstring(testval,testChar);

            Assert.AreEqual(returnedVal, expectedVal);

        }
        [Test()]
        public void LongestSubStringTest_12()
        {
            var testval = "Raghuveer";
            var testChar = 'e';
            var expectedVal = 2;

            var returnedVal = DhivishaExp.findCharCountInstring(testval, testChar);

            Assert.AreEqual(returnedVal, expectedVal);

        }
        [Test()]
        public void LongestSubStringTest_2()
        {
            var testval = "abcabcbb";
            var testChar = 'c';
            var expectedVal = 2;

            var returnedVal = DhivishaExp.findCharCountInstring(testval, testChar);

            Assert.AreEqual(returnedVal, expectedVal);

        }
        [Test()]
        public void LongestSubStringTest_3()
        {
            var testval = "How Are you";
            var testChar = 'o';
            var expectedVal = 2;

            var returnedVal = DhivishaExp.findCharCountInstring(testval, testChar);

            Assert.AreEqual(returnedVal, expectedVal);

        }
        [Test()]
        public void LongestSubStringTest_4()
        {
            var testval = "abcabcbb";
            var testChar = 'c';
            var expectedVal = 2;

            var returnedVal = DhivishaExp.findCharCountInstring(testval, testChar);

            Assert.AreEqual(returnedVal, expectedVal);

        }

    }
}
