using System.Collections.Generic;
using System.Linq;


class Family
{
    private List<Person> familyMembes;

    public Family()
    {
        this.familyMembes = new List<Person>();
    }

    public void AddMember(Person member)
    {
        this.familyMembes.Add(member);
    }

    public Person GetOldestMember()
    {

        return this.familyMembes.OrderByDescending(a => a.Age).FirstOrDefault();
    }
}

