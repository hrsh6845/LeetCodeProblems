namespace LeetCode.NET;

public class LeetCodeProblems_Easy
{
    /// <summary>
    /// https://leetcode.com/problems/average-salary-excluding-the-minimum-and-maximum-salary
    /// Problem Id : 1491
    /// </summary>
    /// <param name="salary">Salary of employees</param>
    /// <returns>Average salary excluding max and min of the employees</returns>
    public double AverageSalaryExcludingMinimumAndMax_1491(int[] salary)
    {
        Array.Sort(salary);
        int totalSalary = 0;
        for (int i = 0; i < salary.Length; i++)
        {
            if(i == 0 || i == salary.Length - 1)
                continue;
            totalSalary += salary[i];
        }
        return totalSalary / Convert.ToDouble(salary.Length - 2);
    }

    /// <summary>
    /// https://leetcode.com/problems/two-sum/description/
    /// Problem Id : 1
    /// </summary>
    /// <param name="nums">Array of integers</param>
    /// <param name="target">target</param>
    /// <returns>Indices of the two numbers such that they add up to target.</returns>
    public int[] TwoSum_1_BruteForce(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for(int j = 0; j < nums.Length; j++)
            {
                if (j == i)
                    continue;

                if (nums[j] + nums[i] == target)
                    return new int[] { i, j };
            }
        }

        return new int[] { 0, 0 };
    }

    /// <summary>
    /// https://leetcode.com/problems/palindrome-number/description/
    /// Problem Id : 9
    /// </summary>
    /// <param name="x">return true if number x is a palindrome.</param>
    /// <returns>boolean value</returns>
    public bool IsPalindromeNumber_9(int x)
    {
        // get remainder of the number

        int remainder = 0;
        int number = x;
        while (number > 0)
        {
            remainder = remainder * 10 + number % 10;
            number /= 10;
        }
        return remainder == x;
    }

    /// <summary>
    /// https://leetcode.com/problems/roman-to-integer/description/
    ///
    /// Problem Id : 13
    /// </summary>
    /// <param name="s">input string.</param>
    /// <returns>Convert given string to Roman Numberals.</returns>
    public int RomanToInt_13(string s)
    {

    }
}