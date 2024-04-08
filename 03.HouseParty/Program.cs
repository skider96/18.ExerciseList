using System.Threading.Channels;

namespace _03.HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            List<string> guestList = new List<string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                if (input.Length == 3)
                {
                    if (!guestList.Contains(input[0]))
                    {
                        guestList.Add(input[0]);
                        continue;
                    }

                    Console.WriteLine($"{input[0]} is already in the list!");
                }
                else if (input.Length == 4) 
                {
                    if (guestList.Contains(input[0]))
                    {
                        guestList.Remove(input[0]);
                        continue;
                    }

                    Console.WriteLine($"{input[0]} is not in the list!");
                }
            }
              
            guestList.ForEach(g => Console.WriteLine(g));
        }
    }
}