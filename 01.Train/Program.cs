using System.Threading.Channels;

namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagonsList = Console.ReadLine().Split().Select(int.Parse).ToList();

            int maxWagonCapacity = int.Parse(Console.ReadLine());

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] act = command.Split().ToArray();
                int number = 0;
                if (act.Length == 2 && act[0] == "Add" && int.TryParse(act[1], out number))
                {
                    wagonsList.Add(number);
                }
                else if (act.Length == 1 && int.TryParse(act[0], out number))
                {
                    int lastEmptyWagon = wagonsList.FindIndex(w => maxWagonCapacity - w >= int.Parse(act[0]));

                    if (lastEmptyWagon != -1) wagonsList[lastEmptyWagon] += number;
                }
            }

            wagonsList.ForEach(w => Console.Write(w + " "));
        }
    }
}