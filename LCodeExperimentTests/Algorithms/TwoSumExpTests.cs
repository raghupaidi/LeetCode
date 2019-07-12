using NUnit.Framework;
using LCodeExperiments.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCodeExperiments.Algorithms.Tests
{
    [TestFixture()]
    public class TwoSumExpTests
    {
        [Test()]
        public void TwoSumTest()
        {
            var twoSumExp = new TwoSumExp();

            var numArray = new int[4];
            numArray[0] = 2;
            numArray[1] = 7;
            numArray[2] = 11;
            numArray[3] = 15;

            var target = 9;

            var result = twoSumExp.TwoSum(numArray, target);

            Assert.True(result[0]==0);
            Assert.True(result[1] == 1);
        }

        [Test()]
        public void TwoSumTest_2()
        {
            var twoSumExp = new TwoSumExp();

            var numArray = new int[3];
            numArray[0] = 3;
            numArray[1] = 2;
            numArray[2] = 4;

            var target = 6;

            var result = twoSumExp.TwoSum(numArray, target);

            Assert.True(result[0] == 1);
            Assert.True(result[1] == 2);
        }

        [Test()]
        public void TwoSumTest_3()
        {
            var twoSumExp = new TwoSumExp();

            var numArray = new int[2];
            numArray[0] = 3;
            numArray[1] = 3;
            var target = 6;

            var result = twoSumExp.TwoSum(numArray, target);

            Assert.True(result[0] == 0);
            Assert.True(result[1] == 1);
        }

        [Test()]
        public void TwoSumTest_4()
        {
            var twoSumExp = new TwoSumExp();

            var numArray = new int[4];
            numArray[0] = 2;
            numArray[1] = 7;
            numArray[2] = 11;
            numArray[3] = 15;
            var target = 9;

            var result = twoSumExp.TwoSum(numArray, target);

            Assert.True(result[0] == 0);
            Assert.True(result[1] == 1);
        }
    }
}