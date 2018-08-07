using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

public class Student:Human
{

    private string facultyNumber;

    public string FacultyNumber
    {
        get { return facultyNumber; }
        protected set
        {
            var pattern = new Regex("^[a-zA-Z0-9]{5,10}$");
            Match match = pattern.Match(value);
            if (!match.Success)
            {
                throw new ArgumentException("Invalid faculty number!");
            }
            facultyNumber = value;
        }
    }

    public Student(string firstName, string lastName, string facultyNumber)
        :base(firstName, lastName)
    {
        this.FacultyNumber = facultyNumber;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append(base.ToString())
            .AppendLine($"Faculty number: {this.facultyNumber}");
        return sb.ToString();
    }
}

