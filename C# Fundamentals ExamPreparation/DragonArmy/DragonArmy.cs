using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_11_DragonArmy
{
    class DragonArmy
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var result = new Dictionary<string, SortedDictionary<string, DragonInfo>>();


            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
                if (input.Length != 5)
                {
                    input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
                    continue;
                }
                var type = input[0];
                var name = input[1];
                var health = 250;
                var damage = 45;
                var armor = 10;

                if (input[2] != "null")
                {
                    damage = int.Parse(input[2]);
                }

                if (input[3] != "null")
                {
                    health = int.Parse(input[3]);
                }

                if (input[4] != "null")
                {
                    armor = int.Parse(input[4]);
                }

                if (!result.ContainsKey(type))
                {
                    var currDragonInfo = new DragonInfo
                    {
                        Damage = damage,
                        Health = health,
                        Armor = armor
                    };

                    result.Add(type, new SortedDictionary<string, DragonInfo>());
                    result[type].Add(name, currDragonInfo);
                }
                else if (!result[type].ContainsKey(name))
                {

                    result[type][name] = new DragonInfo();
                    result[type][name].Damage = damage;
                    result[type][name].Health = health;
                    result[type][name].Armor = armor;

                }
                else
                {
                    result[type][name].Damage = damage;
                    result[type][name].Health = health;
                    result[type][name].Armor = armor;
                }

            }

            foreach (var item in result)
            {

                var averageDamage = item.Value.Values.Select(x => x.Damage).Average();
                var averageHealth = item.Value.Values.Select(x => x.Health).Average();
                var averageArmor = item.Value.Values.Select(x => x.Armor).Average();

                Console.WriteLine($"{item.Key}::({averageDamage:f2}/{averageHealth:f2}/{averageArmor:f2})");

                foreach (var name in item.Value)
                {
                    Console.WriteLine($"-{name.Key} -> damage: {name.Value.Damage}, health: {name.Value.Health}, armor: {name.Value.Armor}");
                }
            }

        }
        class DragonInfo
        {
            public int Damage { get; set; }
            public int Health { get; set; }
            public int Armor { get; set; }
        }
    }
}