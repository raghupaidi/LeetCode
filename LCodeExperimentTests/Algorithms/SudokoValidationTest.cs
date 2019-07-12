using LCodeExperiments.Algorithms;
using NUnit.Framework;

namespace LCodeExperimentTests.Algorithms
{
    [TestFixture()]
    public class SudokoValidationTest
    {
        public SudokoValidaiton _SudokoValidation { get; set; }

        [OneTimeSetUp()]
        public void Setup()
        {
            _SudokoValidation = new SudokoValidaiton();
        }

        [Test()]
        public void SudokoValidationTest_1()
        {
            var testval = new char[][] {
                 new char[] {'5', '3', '.', '.', '7', '.', '.', '.', '.'},
                 new char[] {'6', '.', '.', '1', '9', '5', '.', '.', '.'},
                 new char[] {'.', '9', '8', '.', '.', '.', '.', '6', '.'},
                 new char[] {'8', '.', '.', '.', '6', '.', '.', '.', '3'},
                 new char[] {'4', '.', '.', '8', '.', '3', '.', '.', '1'},
                 new char[] {'7', '.', '.', '.', '2', '.', '.', '.', '6'},
                 new char[] {'.', '6', '.', '.', '.', '.', '2', '8', '.'},
                 new char[] {'.', '.', '.', '4', '1', '9', '.', '.', '5' },
                 new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9'}
                };

            var expectedVal = true;

            var returnedVal = _SudokoValidation.IsValidSudoku(testval);

            Assert.AreEqual(expectedVal, returnedVal);

        }

        [Test()]
        public void SudokoValidationTest_2()
        {
            var testval = new char[][] {
                 new char[] {'5', '3', '.', '.', '7', '.', '.', '.', '.'},
                 new char[] {'6', '.', '.', '1', '9', '5', '.', '.', '.'},
                 new char[] {'.', '9', '8', '.', '.', '.', '.', '6', '.'},
                 new char[] {'8', '.', '.', '.', '6', '.', '.', '.', '3'},
                 new char[] {'4', '.', '.', '8', '.', '3', '.', '.', '1'},
                 new char[] {'7', '.', '.', '.', '2', '.', '.', '.', '6'},
                 new char[] {'.', '6', '.', '.', '.', '.', '2', '8', '.'},
                 new char[] {'.', '.', '.', '4', '1', '9', '.', '.', '5' },
                 new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9'}
                };

            var expectedVal = true;

            var returnedVal = _SudokoValidation.IsValidSudoku_v2(testval);

            Assert.AreEqual(expectedVal, returnedVal);

        }
    }
}
