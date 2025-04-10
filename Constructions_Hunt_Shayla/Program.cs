namespace Constructions_Hunt_Shayla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game myGame = new Game("Minecraft", "E10+ for Everyone 10+");

            Console.WriteLine($"My favorite game is {myGame.title} and it is {myGame.genre}!");

            Game myOtherGame = new Game();

            Console.WriteLine($"My other favorite game is {myOtherGame} and it is {myOtherGame.genre}!");
        }
    }
}
