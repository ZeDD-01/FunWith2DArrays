using System;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            const int DRAW_ARRAY_ELEMENTS = 1;
            const int DRAW_CHOSEN_CHARACTER = 2;
            
            Console.WriteLine("Hi, using this program you can create 2D-arrays");
            Console.WriteLine("Please enter the amount of columns and rows the array should have");

            Console.Write("Enter the number of rows: ");
            int row = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of columns: ");
            int col = int.Parse(Console.ReadLine());
            
            Console.Write("\nDo you want a frame around each cell? (y/n): ");
            bool useFrame = Console.ReadLine().ToLower() == "y";
            
            Console.WriteLine("\nYou can decide what should be contained in the array:");
            Console.WriteLine("1. The indices of the array elements");
            Console.WriteLine("2. Choose your own character");
            Console.Write("Your choice = ");
            int userDefinedContent = int.Parse(Console.ReadLine());

            char userDefinedChar = ' ';

            if (userDefinedContent == DRAW_CHOSEN_CHARACTER)
            {
                Console.Write("Please choose the character the array should be filled with: ");
                userDefinedChar = char.Parse(Console.ReadLine());
            }
            
            //Fill the Array
            string[,] userDefinedArray = new string[row, col];

            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    if (userDefinedContent == DRAW_ARRAY_ELEMENTS)
                        userDefinedArray[r, c] = $"{r}{c}";
                    else
                        userDefinedArray[r, c] = $"  {userDefinedChar}";
                }
            }
            
            //Print the Array
            Console.WriteLine("\nYour generated array:\n");

            for (int r = 0; r < row; r++)
            {
                if (useFrame)
                {
                    for (int c = 0; c < col; c++)
                        Console.Write("+----");
                    Console.WriteLine("+");
                }

                if (useFrame)
                {
                    for (int c = 0; c < col; c++)
                        Console.Write($"| {userDefinedArray[r, c],2} ");
                    Console.WriteLine("|");
                }
                else
                {
                    for (int c = 0; c < col; c++)
                        Console.Write($"{userDefinedArray[r, c]} ");
                    Console.WriteLine();
                }
            }

            if (useFrame)
            {
                for (int c = 0; c < col; c++)
                    Console.Write("+----");
                Console.WriteLine("+");
            }
        }
    }
}
