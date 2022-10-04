using System;

namespace ClassVsStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player(100, 25);
            Player player2 = player1;
            Console.WriteLine("Player1:" + player1.Health + " " + player1.Armor);
            Console.WriteLine("Player2:" + player2.Health + " " + player2.Armor);
            DoubleHealth(ref player1);
            Console.WriteLine("Player1:" + player1.Health + " " + player1.Armor);
            Console.WriteLine("Player2:" + player2.Health + " " + player2.Armor);
        }

        private static void DoubleHealth(ref Player player)
        {
            player.Health *= 2;
            
        }
    }
}
