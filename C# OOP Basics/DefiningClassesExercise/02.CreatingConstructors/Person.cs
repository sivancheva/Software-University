using System;


public class Person
{
   
    private string name;
    private int age;


    public Person() // tuk ne podavame ni6to, a direktno na gore definiranite age i name im zadavame stoinosti
    {
        this.name = "No name"; 
        this.age = 1;

        //same as
        //public Person() : this("No name", 1)
        //{
        //}
    }

    public Person(int age) : this() // age, koito sme definirali gore stava raven na podadenija age
    {
        this.age = age;
    }

    public Person(string name, int age) // analogi4no  age i name se priravnjavat na podadenite name i age
    {
        this.name = name;
        this.age = age;
    }



    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

}



