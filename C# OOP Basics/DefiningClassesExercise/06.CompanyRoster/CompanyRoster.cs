using System;
using System.Collections.Generic;
using System.Linq;

//name, salary, position, department, email

public class CompanyRoster
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        var employees = new List<Employee>();

        for (int i = 0; i < n; i++)
        {
            var inputArr = Console.ReadLine().Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries).Select(x=>x.Trim()).ToArray();

            var name = inputArr[0];
            var salary = decimal.Parse(inputArr[1]);
            var position = inputArr[2];
            var department = inputArr[3];

            var currentEmployee = new Employee(name, salary, position, department);

            if (inputArr.Length == 6)
            {
                currentEmployee.Email = inputArr[4];
                currentEmployee.Age = int.Parse(inputArr[5]);
            }
            if (inputArr.Length == 5)
            {
                if (char.IsDigit(inputArr[4][0]))
                {
                    currentEmployee.Age = int.Parse(inputArr[4]);
                }
                else
                {
                    currentEmployee.Email = inputArr[4];
                }
            }
            employees.Add(currentEmployee);

        }

        var highesAverageSalaryByDepartment = employees.GroupBy(e => e.Department)
                                                        .OrderByDescending(s=>s.Select(e=>e.Salary).Average())
                                                        .First();

        Console.WriteLine($"Highest Average Salary: {highesAverageSalaryByDepartment.Key}");

        foreach (var employee in highesAverageSalaryByDepartment.OrderByDescending(e=>e.Salary))
        {
            Console.WriteLine($"{employee.Name} {employee.Salary:f2} {employee.Email} {employee.Age}");
        }


    }
}

