using LCodeExperiments.Algorithms;
using NUnit.Framework;


namespace LCodeExperimentTests.Algorithms
{

    [TestFixture()]
    public class MedianOfArrayTest
    {
        public MedianOfArrays _MedianOfArrays { get; set; }

        [OneTimeSetUp()]
        public void Setup()
        {
            _MedianOfArrays = new MedianOfArrays();
        }

        [Test()]
        public void MedianOfArraysTest_1()
        {
            var testnums1 = new int[] { 1, 3 };
            var testnums2 = new int[] { 2 };

            var expectedVal = 2.0;

            var returnedVal = _MedianOfArrays.FindMedianSortedArrays(testnums1,testnums2);

            Assert.AreEqual(expectedVal, returnedVal);

        }

        [Test()]
        public void MedianOfArraysTest_2()
        {
            var testnums1 = new int[] { 1, 2 };
            var testnums2 = new int[] { 3,4 };

            var expectedVal = 2.5;

            var returnedVal = _MedianOfArrays.FindMedianSortedArrays(testnums1, testnums2);

            Assert.AreEqual(expectedVal, returnedVal);

        }

        /*
         * []
[1]
         */

        [Test()]
        public void MedianOfArraysTest_3()
        {
            var testnums1 = new int[] {  };
            var testnums2 = new int[] { 1};

            var expectedVal = 1;

            var returnedVal = _MedianOfArrays.FindMedianSortedArrays(testnums1, testnums2);

            Assert.AreEqual(expectedVal, returnedVal);

        }

        /*[]
[1,2,3,4,5]
         */

        [Test()]
        public void MedianOfArraysTest_4()
        {
            var testnums1 = new int[] { };
            var testnums2 = new int[] { 1,2,3,4,5 };

            var expectedVal = 3;

            var returnedVal = _MedianOfArrays.FindMedianSortedArrays(testnums1, testnums2);

            Assert.AreEqual(expectedVal, returnedVal);

        }
    }
}
