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
                    //    integers.Where(x => x == act[1])
                }
            }

            //TO BE SOLVED
        }
    }
}