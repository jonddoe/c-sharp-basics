using System;

namespace SalaryCalculator
{
    public class SalaryCalculator
    {
        public static string SalaryCalculation(string employeeId, double basePay, int hoursWorked)
        {
            var salary = basePay * hoursWorked;
            var overtimeHours = hoursWorked - 40;
            const double minimumWage = 8.0;
            const int maxHoursWorked = 60;

            if (basePay < minimumWage || hoursWorked > maxHoursWorked)
            {
                return $"{employeeId}: Error in salary calculation!";
            }

            if (overtimeHours > 0)
            {
                var overtimeSalary = Convert.ToInt32((overtimeHours * basePay) * 1.5);
                return
                    $"{employeeId} salary is: {salary:0.00}\n{employeeId} overtime salary is: {overtimeSalary:0.00}\n{employeeId} total salary is: {salary + overtimeSalary:0.00}";
            }

            return $"{employeeId} salary is: {salary:0.00}";
        }
    }
}