using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC2_Player_Rolls_the_Die
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake & Ladder\n");
            Console.WriteLine("Game Begin\n");
            Console.WriteLine("Currently player at position 0 \n");
            int getDieNumber;
            Random random = new Random();   // Creating Object for random Method
            getDieNumber = random.Next(1, 7);   //Generates random number 1 to 6
            Console.WriteLine("The number displayed on the die is: " + getDieNumber);

            Console.ReadLine();
        }
    }
}
