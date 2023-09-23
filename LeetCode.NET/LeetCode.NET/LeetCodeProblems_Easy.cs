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
}