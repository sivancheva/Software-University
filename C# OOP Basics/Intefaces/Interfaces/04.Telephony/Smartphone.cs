using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Smartphone : ICallable, IBrowsable
{
    private List<string> allCalls;
    private List<string> searchedWebsites;

    public Smartphone(string allCalls, string searchedWebsites)
    {
        this.AllCalls = new List<string>();
        this.SearchedWebsites = new List<string>();
    }

    public List<string> AllCalls
    {
        get { return allCalls; }
        set { allCalls = value; }
    }
    public List<string> SearchedWebsites
    {
        get { return searchedWebsites; }
        set { searchedWebsites = value; }
    }

    public List<string> GetCalls(string calls)
    {

        var callsInput = calls.Split();
        foreach (var number in callsInput)
        {
            
            if (number.All(char.IsDigit))
            {
                Console.WriteLine($"Calling... {number}");
                allCalls.Add(number);
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }
        return allCalls;
    }


    public List<string> GetBrowsedSites(string sites)
    {
        var sitesInput = sites.Split();
        foreach (var site in sitesInput)
        {

            if (site.Any(char.IsDigit))
            {
                Console.WriteLine("Invalid URL!");
            }
            else
            {
                searchedWebsites.Add(site);
                Console.WriteLine($"Browsing: {site}!");
            }
        }
        return searchedWebsites;
    }

    private void PrintCalls(Smartphone smartphone)
    {
        foreach (var call in smartphone.AllCalls)
        {
            Console.WriteLine($"Calling... {call}");
        }
    }

    
}

