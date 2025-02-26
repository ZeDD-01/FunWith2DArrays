namespace MyProject;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hi, using this program you can create 2D-arrays\nPlease enter the amount of columns and rows the array should have");
        Console.WriteLine("Enter the number of rows: ");
        int col = int.Parse(Console.ReadLine()); 
        Console.WriteLine("Enter the number of columns: ");
        int row = int.Parse(Console.ReadLine());
        
        int[,] userDefinedArray = new int[col, row];
        
        Console.WriteLine("You can decide what should be contained in the array\n 1. the indices of the single array elements\n 2. The number 10");
        Console.WriteLine("Your choice = ");
        int userDefinedContent = int.Parse(Console.ReadLine());

        int counter = 1;
        for (int i = 0; i < col; i++)
        {
            for (int j = 0; j < row; j++)
            {
                if (userDefinedContent == 1)
                {
                    userDefinedArray[i, j] = counter;
                    
                }
                if (userDefinedContent == 2)
                {
                    userDefinedArray[i, j] = 10;
                }
                Console.Write(userDefinedArray[i, j] + " | ");
                counter++;
            }
                Console.WriteLine("\n");
        }
    }
}