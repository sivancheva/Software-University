using System;
using System.Collections.Generic;
using System.Text;


public class Human
{
    private const int MinFirstNameLength = 4;
    private const int MinLastNameLength = 3;
    private string firstName;
    private string lastName;

    public Human(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    public string FirstName
    {
        get { return firstName; }
        protected set
        {
             
            if (char.IsLower(value[0]))
            {
                throw new ArgumentException($"Expected upper case letter! Argument: {nameof(this.firstName)}");
            }
            if (value.Length < MinFirstNameLength)
            {
                throw new ArgumentException($"Expected length at least {MinFirstNameLength} symbols!Argument: {nameof(this.firstName)}");
                
            }
            
            firstName = value;
        }
    }

    public string LastName
    {
        get { return lastName; }
        set
        {
            if (char.IsLower(value[0]))
            {
                throw new ArgumentException($"Expected upper case letter! Argument: {nameof(this.lastName)}");
            }
            if (value.Length < MinLastNameLength)
            {
                throw new ArgumentException($"Expected length at least {MinLastNameLength} symbols! Argument: {nameof(this.lastName)}");
            }
            lastName = value;
        }
    }
    
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"First Name: {this.firstName}")
          .AppendLine($"Last Name: {this.lastName}");

        return sb.ToString();
    }
}

