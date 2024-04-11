using System.Data;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;

namespace _04.ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                bool isValidIndex = false;
                string[] operations = command.Split().ToArray();

                if (operations[0] == "Add" && operations.Length == 2)
                {
                    int givenNumber = int.Parse(operations[1]);
                    numbersList.Add(givenNumber);
                }
                else if (operations[0] == "Insert" && operations.Length == 3)
                {
                    int givenNumber = int.Parse(operations[1]);
                    int index = int.Parse(operations[2]);

                    if (index >= numbersList.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    numbersList.Insert(index, givenNumber);
                }
                else if (operations[0] == "Remove" && operations.Length == 2)
                {
                    int index = int.Parse(operations[1]);

                    if (index >= numbersList.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    numbersList.RemoveAt(index);
                }
                else if (operations[0] == "Shift" && operations[1] == "left" && operations.Length == 3)
                {
                    for (int i = 0; i < int.Parse(operations[2]); i++)
                    {
                        int firstNumuber = numbersList[0];

                        int chosenIndex = 0;
                        numbersList.RemoveAt(chosenIndex);

                        numbersList.Add(firstNumuber);
                    }
                }
                else if (operations[0] == "Shift" && operations[1] == "right" && operations.Length == 3)
                {
                    for (int i = 0; i < int.Parse(operations[2]); i++)
                    {
                        int lastNumber = numbersList[^1];

                        numbersList.RemoveAt(numbersList.Count - 1);
                        numbersList.Insert(0, lastNumber);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid index");
                }
            }
            Console.WriteLine(string.Join(" ", numbersList));
        }
    }
}