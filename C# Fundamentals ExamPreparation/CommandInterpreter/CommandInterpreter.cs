using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CommandInterpreter
{
    class CommandInterpreter
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(s => s.Trim()).ToArray();

            var modifiedList = new List<string>(input).ToList();
            int lenght = modifiedList.Count - 1;

            var command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(s => s.Trim()).ToArray();

            while (command[0] != "end")
            {

                if (command[0] == "reverse" || command[0] == "sort")
                {
                    int start = int.Parse(command[2]);
                    int count = int.Parse(command[4]);
                    if ((start < 0) || (count < 1) || ((start + count) > input.Length) || (start > input.Length - 1)
                        || (count > input.Length))
                    {
                        Console.WriteLine("Invalid input parameters.");
                        goto END;
                    }

                    if (command[0] == "reverse")
                    {

                        modifiedList.Reverse(start, count);
                    }

                    else if (command[0] == "sort")
                    {

                        modifiedList.Sort(start, count, null);

                    }

                }
                else if (command[0] == "rollLeft" || command[0] == "rollRight")
                {

                    int count = int.Parse(command[1]);

                    if (count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        goto END;
                    }


                    if (count > input.Length)
                    {
                        count %= input.Length;
                    }

                    if (command[0] == "rollRight")

                    {
                        for (int i = 0; i < count; i++)
                        {
                            modifiedList.Insert(0, modifiedList[lenght]);
                            modifiedList.RemoveAt(lenght + 1);
                        }
                    }
                    else if (command[0] == "rollLeft")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            modifiedList.Add(modifiedList[0]);
                            modifiedList.RemoveAt(0);
                        }
                    }

                }
                END:

                command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(s => s.Trim()).ToArray();
            }

            Console.WriteLine("[" + String.Join(", ", modifiedList) + "]");
        }
    }
}
