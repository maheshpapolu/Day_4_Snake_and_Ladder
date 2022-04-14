using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC3_Check_the_Ladder_or_Snake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake & Ladder\n");
            Console.WriteLine("Game Begin\n");
            Console.WriteLine("Currently player at position 0 \n");
            int totalBoardNumber = 100;
            int currentBoardPosition = 0;
            int getDieNumber;
            int[] snake = {5, 15, 35, 67, 88, 98 };     // Creating array for positions of snakes in board
            int[] ladder = { 6, 13, 30, 45, 56, 78 };   // Creating array for positions of ladders in board
            Random random = new Random();   // Creating Object for random Method
            getDieNumber = random.Next(1, 7);   //Generates random number 1 to 6
            Console.WriteLine("The number displayed on the die is: " + getDieNumber);
            currentBoardPosition += getDieNumber;
            Console.WriteLine("\nNow your position is : " +  currentBoardPosition);
            if(Array.Exists(snake, x => x == currentBoardPosition)) //Checking the current position is snake or not
            {
                currentBoardPosition -= getDieNumber;   //if it's a snake because of steps behind by dice number
                Console.WriteLine($"\n YOu reached snake head position, So you moved {getDieNumber} steps behind");
            }
            if(Array.Exists(ladder, x => x == currentBoardPosition))    // checking the bottom of the ladder position
            {
                Console.WriteLine($"\n You reached at bottom of ladder, So you moved {getDieNumber} steps ahead\n");
                currentBoardPosition += getDieNumber;   //it,s ladder that's why moves steps a head by dice number
            }
            Console.WriteLine("\nYou are now at positon: " + currentBoardPosition);
            Console.ReadLine();
        }
    }
}
