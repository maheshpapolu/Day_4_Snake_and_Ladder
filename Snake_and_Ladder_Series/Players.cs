using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC7_Play_the_Game_With_TwoPlayers
{
     class Player
    {
        int[] snake = { 5, 15, 35, 67, 88, 98 };     // Creating array for positions of snakes in board
        int[] ladder = { 6, 13, 30, 45, 56, 78 };   // Creating array for positions of ladders in board
        int id;
        public int currentBoardPosition;
        public int getDieNumber;
        public int countDiceRolls;
        public Player(int id)  // Constructor for class players
        {
            this.id = id;
            currentBoardPosition = 0;
            countDiceRolls = 0;
        }
        public void Dicerolls()     // Object for Random Class
        {
            Random random = new Random();   // Creating Object for random Method
            getDieNumber = random.Next(1, 7);   //Generates random number 1 to 6
            countDiceRolls++;
            Console.WriteLine("The number displayed on the die is: " + getDieNumber);
        }
        public void Moves()
        {
            currentBoardPosition += getDieNumber;
            Console.WriteLine("\nNow your position is : " + currentBoardPosition);
            if (Array.Exists(snake, x => x == currentBoardPosition)) //Checking the current position is snake or not
            {
                currentBoardPosition -= getDieNumber;   //if it's a snake because of steps behind by dice number
                Console.WriteLine($"\n YOu reached snake head position, So you moved {getDieNumber} steps behind");
                Console.WriteLine($"\n Now you are at position : {currentBoardPosition}");
            }
            if (Array.Exists(ladder, x => x == currentBoardPosition))    // checking the bottom of the ladder position
            {
                Console.WriteLine($"\n You reached at bottom of ladder, So you moved {getDieNumber} steps ahead\n");
                currentBoardPosition += getDieNumber;   //it,s ladder that's why moves steps a head by dice number
                Console.WriteLine($"\n Now you are at position : {currentBoardPosition}");
                Console.WriteLine("\n Again your turn");
                Dicerolls();
                Moves();
            }
            if (currentBoardPosition > 100)       // Checking that if current position is total board number or above
            {
                Console.WriteLine("You get out of range position");
                currentBoardPosition -= getDieNumber;   //player position remains same if player get out of range position
                Console.WriteLine($"\n Now you are at position : {currentBoardPosition}");
            }
            if (currentBoardPosition < 0) // in case current position is 0 then player restart the game
            {
                currentBoardPosition = 0;
                Console.WriteLine("\nYou are now at positon: " + currentBoardPosition);
            }

        }

    }
}
