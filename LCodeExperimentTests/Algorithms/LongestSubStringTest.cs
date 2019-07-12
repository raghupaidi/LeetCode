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
    public class LongestSubStringTest
    {
        public LongestSubString LongestSubString { get; set; }

        [OneTimeSetUp()]
        public void Setup()
        {
            LongestSubString = new LongestSubString();
        }

        [Test()]
        public void LongestSubStringTest_1()
        {
            var testval = "abcabcbb";
            var expectedVal = 3;

            var returnedVal = LongestSubString.LengthOfLongestSubstring(testval);

            Assert.Equals(returnedVal, expectedVal);

        }
    }
}
