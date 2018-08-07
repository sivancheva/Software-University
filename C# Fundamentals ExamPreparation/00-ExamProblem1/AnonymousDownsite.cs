using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _00_ExamProblem1
{
    class AnonymousDownsite
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int securityKey = int.Parse(Console.ReadLine());

            var sites = new List<string>();
            decimal totalLoss = 0m;

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new char[] {' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList();
                string website = input[0];
                sites.Add(website);
                
                totalLoss += decimal.Parse(input[1]) * decimal.Parse(input[2]);
            }

            foreach (var site in sites)
            {
                Console.WriteLine(site);
            }

            Console.WriteLine($"Total Loss: {totalLoss:f20}");

            BigInteger securityToken = securityKey;

            for (int i = 1; i < sites.Count; i++)
            {
                securityToken *= (BigInteger)securityKey;
            }

            Console.WriteLine($"Security Token: {securityToken}");
        }
    }
}
