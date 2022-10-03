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
            player1.Health = DoubleHealth(player1);
            Console.WriteLine("Player1:" + player1.Health + " " + player1.Armor);
            Console.WriteLine("Player2:" + player2.Health + " " + player2.Armor);
        }

        static int DoubleHealth(Player player)
        {
            return player.Health * 2;
        }
    }
}
