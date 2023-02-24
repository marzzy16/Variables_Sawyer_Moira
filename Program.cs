

using System;

namespace Variables_Sawyer_Moira
{
    class Program
    {
        static void Main(string[] args)
        {
             // Declares an integer to store a favorite number
            int favoriteNumber;
            // Booleans initialized to false for jumping and running
            bool isjumping = false, isRunning = false;
            // Declared random float variable 
            float myFloat;
            // assigning the favoriteNumber to 6
            favoriteNumber = 6;
            // Assigning myFloat variable
            myFloat = 54.65f;
            // Assigning myFloat to 54.65
            const double finalGrade = 90.0;
            // Initializing constant finalGrade to 90

            // Prints all variables to console 
            Console.WriteLine("Favorite #: " + favoriteNumber);
            Console.WriteLine("jumping:" + isjumping);
            Console.WriteLine("Running: " + isRunning);
            Console.WriteLine("Random Floating #:" + myFloat);
            Console.WriteLine("Final Grade: " + finalGrade);
        }
    }
}
