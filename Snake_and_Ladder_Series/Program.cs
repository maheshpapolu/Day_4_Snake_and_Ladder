using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC7_Play_the_Game_With_TwoPlayers
{
    internal class Program
    {
        public static int totalBoardNumber = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake & Ladder\n");
            Console.WriteLine("Game Begin\n");
            Console.WriteLine("Currently player at position 0 \n");
            // Creating objects for 2 players
            Player player1 = new Player(1);
            Player player2 = new Player(2);
            while (true)
            {
                Console.WriteLine("\nPlayer1 turn : ");
                player1.Dicerolls(); // calling Dicerolls Method for player1 
                player1.Moves();    //Calling Condition Checking for Player1
                if (player1.currentBoardPosition == Program.totalBoardNumber)
                {
                    Console.WriteLine("Congratulations...Player1 WON the Game");
                    break;

                }
                // Calling same methods for player2
                Console.WriteLine("\nPlayer2 turn : ");
                player2.Dicerolls();
                player2.Moves();
                if (player2.currentBoardPosition == Program.totalBoardNumber)
                {
                    Console.WriteLine("Congratulations...Player2 WON the Game");
                    break;
                }
                Console.WriteLine("\n Player1 rolls dices : " + player1.countDiceRolls);
                Console.WriteLine("\n Player2 rolls dices : " + player2.countDiceRolls);
                Console.ReadLine();
            }
        }
    }
}
            