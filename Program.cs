// See https://aka.ms/new-console-template for more information
public class Program 
{
    static void Main()
    {
        Player player = new Player();
        Console.WriteLine("What is your name?");
        player.Name = Console.ReadLine();
        player.WelcomePlayer();
    }
    class Player
    {
        public string Name;
        public void WelcomePlayer()
        {
            Console.WriteLine($"Welcome, {Name}!");
        }
    }
}