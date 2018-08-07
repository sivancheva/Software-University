using System;
using System.Collections.Generic;
using System.Text;


public class Worker:Human
{
    private const int MinSalary = 10;
    private const int MinWorkingHoursPerDay = 1;
    private const int MaxWorkingHoursPerDay = 12;
    private decimal weekSalary;
    private decimal workHoursPerDay;

    public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay)
        :base(firstName, lastName)
    {
        this.WeekSalary = weekSalary;
        this.WorkHoursPerDay = workHoursPerDay;
    }

    public decimal WeekSalary
    {
        get { return weekSalary; }
        protected set
        {
            if (value < MinSalary)
            {
                throw new ArgumentException($"Expected value mismatch! Argument: {nameof(this.weekSalary)}");
            }

            weekSalary = value;
        }
    }
    public decimal WorkHoursPerDay
    {
        get { return workHoursPerDay; }
        protected set
        {
            if (value > MaxWorkingHoursPerDay || value < MinWorkingHoursPerDay)
            {
                throw new ArgumentException($"Expected value mismatch! Argument: {nameof(this.workHoursPerDay)}");
            }
            workHoursPerDay = value;
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append(base.ToString())
            .AppendLine($"Week Salary: {this.weekSalary:f2}")
            .AppendLine($"Hours per day: {this.workHoursPerDay:f2}")
            .AppendLine($"Salary per hour: {GetSalaryPerHour(this.weekSalary, this.workHoursPerDay):f2}");

        return sb.ToString();
    }

    public decimal GetSalaryPerHour(decimal weekSalary, decimal workHoursPerDay)
    {
        var salaryPerDay = this.weekSalary /5;
        return salaryPerDay / this.workHoursPerDay;
    }

}

