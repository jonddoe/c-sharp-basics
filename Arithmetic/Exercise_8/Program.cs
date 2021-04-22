using System;

namespace Exercise_8
{
    class Program
    {
        private static void SalaryCalculation(string employeeId, double basePay, int hoursWorked)
        {
            var salary = basePay * hoursWorked;
            var overtimeHours = hoursWorked - 40;
            var minimumWage = 8.0;
            var maxHoursWorked = 60;

            if (basePay < minimumWage || hoursWorked > maxHoursWorked)
            {
                Console.WriteLine($"{employeeId}: Error in salary calculation!\n");
                return;
            }

            if (overtimeHours > 0)
            {
                var overtimeSalary = Convert.ToInt32((overtimeHours * basePay) * 1.5);
                Console.WriteLine(
                    $"{employeeId} salary is: {salary:0.00}\n{employeeId} overtime salary is: {overtimeSalary:0.00} \n{employeeId} total salary is: {salary + overtimeSalary:0.00}\n");
            }
            else Console.WriteLine($"Your salary is: {salary:0.00}");
        }

        static void Main(string[] args)
        {
            SalaryCalculation("Employee 1", 7.50, 35);
            SalaryCalculation("Employee 2", 8.20, 47);
            SalaryCalculation("Employee 3", 10.00, 73);
        }
    }
}