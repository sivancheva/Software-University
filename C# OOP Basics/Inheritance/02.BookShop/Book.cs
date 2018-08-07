using System;
using System.Collections.Generic;
using System.Text;


public class Book
{
    private const int MinLengthTitle = 3;
    private const int MinPrice = 0;
    private string title;
    private string author;
    private decimal price;

    public Book( string author, string title, decimal price)
    {
        this.Title = title;
        this.Author = author;
        this.Price = price;
    }


    public string Title
    {
        get { return title; }
         protected set
        {
            if (value.Length < MinLengthTitle)
            {
                throw new ArgumentException("Title not valid!");
            }
            title = value;
        }
    }

    public string Author
    {
        get { return author; }
        protected set
        {
            var authorNames = value.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); 
            if (authorNames.Length > 1 && !char.IsLetter(authorNames[1][0]))
            {
                throw new ArgumentException("Author not valid!");
            }
            this.author = value;
        }
    }

    public virtual decimal Price
    {
        get { return price; }
        protected set
        {
            if (value <= MinPrice)
            {
                throw new ArgumentException("Price not valid!");
            }
            price = value;
        }
    }

    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();
        builder.AppendLine($"Type: {this.GetType()}")
            .AppendLine($"Title: {this.Title}")
            .AppendLine($"Author: {this.Author}")
            .AppendLine($"Price: {this.Price:f2}");

        return builder.ToString();
    }
}



