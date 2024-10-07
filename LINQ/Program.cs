namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] videoGames = {"Jak and Dextar", "Rachet and Clank", "Call of Duty", "League of Legends", "Mario"};

            var sortedGames = videoGames.OrderBy(game => game.Length).ToArray();

            foreach (var game in sortedGames)
            {
                Console.WriteLine(game);
            }

        }
    }
}
