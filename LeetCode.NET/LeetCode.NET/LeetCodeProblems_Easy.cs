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
}