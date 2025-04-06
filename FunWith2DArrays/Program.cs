using System;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, using this program you can create 2D-arrays");
            Console.WriteLine("Please enter the amount of columns and rows the array should have");

            Console.Write("Enter the number of rows: ");
            int row = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of columns: ");
            int col = int.Parse(Console.ReadLine());

            string[,] userDefinedArray = new string[row, col];

            Console.WriteLine("\nYou can decide what should be contained in the array:");
            Console.WriteLine("1. The indices of the array elements");
            Console.WriteLine("2. Choose your own character");
            Console.Write("Your choice = ");
            int userDefinedContent = int.Parse(Console.ReadLine());

            char userDefinedChar = ' ';

            if (userDefinedContent == 2)
            {
                Console.Write("Please choose the character the array should be filled with: ");
                userDefinedChar = char.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nYour generated array:\n");

            for (int rowIndex = 0; rowIndex < row; rowIndex++)
            {
                // Print horizontal border
                for (int colIndex = 0; colIndex < col; colIndex++)
                {
                    Console.Write("+----");
                }
                Console.WriteLine("+");

                // Fill and print cell contents
                for (int colIndex = 0; colIndex < col; colIndex++)
                {
                    if (userDefinedContent == 1)
                    {
                        userDefinedArray[rowIndex, colIndex] = $"{rowIndex}{colIndex}";
                    }
                    else
                    {
                        userDefinedArray[rowIndex, colIndex] = $"  {userDefinedChar}";
                    }

                    Console.Write($"| {userDefinedArray[rowIndex, colIndex],2} ");
                }
                Console.WriteLine("|");
            }

            // Print bottom border
            for (int colIndex = 0; colIndex < col; colIndex++)
            {
                Console.Write("+----");
            }
            Console.WriteLine("+");
        }
    }
}
