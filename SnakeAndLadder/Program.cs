namespace SnakeAndLadder;

public class Program
{
    static void Main(string[] args)
    {
        bool flag = true;
        while (flag)
        {
            Console.WriteLine("\nSnake And Ladder Problem");
            Console.WriteLine("1.GameStart \n2.Exit");
            int options = Convert.ToInt32(Console.ReadLine());
            GamePlay game = new GamePlay();
            switch (options)
            {
                case 1:
                    game.Start();
                    break;
                default:
                    flag = false;
                    break;
            }
        }
    }
}