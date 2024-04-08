using System.Security.Cryptography.X509Certificates;

namespace _02.ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] act = command.Split().ToArray();
                int number = 0;
                if (act.Length == 2 && act[0] == "Delete" && int.TryParse(act[1], out number))
                {
                    integers.RemoveAll(x => x == int.Parse(act[1]));
                }
                else if (act.Length == 3 && act[0] == "Insert" && int.TryParse(act[1], out number) && int.TryParse(act[2], out number))
                {
                    integers.Insert(int.Parse(act[2]), int.Parse(act[1]));
                }
            }

            Console.WriteLine(string.Join(" ", integers));
        }
    }
}