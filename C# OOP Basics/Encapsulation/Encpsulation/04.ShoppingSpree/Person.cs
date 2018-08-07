using System;
using System.Collections.Generic;
using System.Text;


public class Person
{
    private string name;
    private decimal money;
    private List<Product> shoppingBag;


    public Person(string name, decimal money)
    {
        var shoppingBag = new List<Product>();
        this.Name = name;
        this.Money = money;
    }
    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException($"{nameof(Name)} cannot be empty");
            }
            name = value;
        }
    }

    public decimal Money
    {
        get { return money; }
        set
        {
            if (value  < 0)
            {
                throw new ArgumentException($"{nameof(Money)} cannot be negative");
            }
            money = value;
        }
    }

}

