namespace LeetCode.NET
{
    public class LeetCodeProblems_Medium
    {
        /// <summary>
        /// https://leetcode.com/problems/longest-string-chain/description/
        /// Problem id : 1048
        /// Credit - https://leetcode.com/Thanat05/
        /// </summary>
        /// <param name="words">array of lower case words.</param>
        /// <returns>the length of longest possible word chain.</returns>
        public int LongestPossibleWordChain_1048(string[] words)
        {
            Dictionary<string, int> dc = new();
            Array.Sort(words, (x, y) => x.Length.CompareTo(y.Length));

            var counter = 0;
            foreach (var word in words)
            {
                dc[word] = 1;
                for (var i = 0; i < word.Length; i++)
                {
                    var previous = word.Remove(i, 1);
                    if (dc.ContainsKey(previous))
                        dc[word] = Math.Max(dc[word], dc[previous] + 1);
                }
                counter = Math.Max(counter, dc[word]);
            }
            return counter;
        }
    }
}