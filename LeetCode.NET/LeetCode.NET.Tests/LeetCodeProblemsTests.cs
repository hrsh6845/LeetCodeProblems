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
    }
}