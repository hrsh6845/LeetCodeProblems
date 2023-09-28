// ReSharper disable StringLiteralTypo
namespace LeetCode.NET.Tests
{
    public class LeetCodeProblemsTests
    {
        private LeetCodeProblems_Medium _problemsMedium;
        private LeetCodeProblems_Easy _easyProblems;

        [SetUp]
        public void Setup()
        {
            _problemsMedium = new LeetCodeProblems_Medium();
            _easyProblems = new LeetCodeProblems_Easy();
        }

        [TestCase(new object[] { "a", "b", "ba", "bca", "bda", "bdca" }, ExpectedResult = 4)]
        [TestCase(new object[] { "xbc", "pcxbcf", "xb", "cxbc", "pcxbc" }, ExpectedResult = 5)]
        [TestCase(new object[] { "abcd", "dbqca" }, ExpectedResult = 1)]
        public int CanCheckLongestPossibleWordChain_1048(params string[] words)
        {
            return _problemsMedium.LongestPossibleWordChain_1048(words);
        }

        [TestCase(new int[] { 1000, 2000, 3000 }, ExpectedResult = 2000.0000)]
        [TestCase(new int[] { 4000, 3000, 1000, 2000 }, ExpectedResult = 2500.0000)]
        public double AverageSalaryExcludingMinimumAndMax_1491_Test(params int[] salary)
        {
            return _easyProblems.AverageSalaryExcludingMinimumAndMax_1491(salary);
        }

        [TestCase(new int[] { 2, 7, 11, 15 }, 9, ExpectedResult = new int[] { 0, 1 })]
        [TestCase(new int[] { 3, 3 }, 6, ExpectedResult = new int[] { 0, 1 })]
        public int[] TwoSum_1_Test(int[] nums, int target)
        {
            return _easyProblems.TwoSum_1_BruteForce(nums, target);
        }

        [TestCase(121, ExpectedResult = true)]
        [TestCase(10, ExpectedResult = false)]
        public bool PalindromeNumber_9_Test(int x)
        {
            return _easyProblems.IsPalindromeNumber_9(x);
        }
    }
}