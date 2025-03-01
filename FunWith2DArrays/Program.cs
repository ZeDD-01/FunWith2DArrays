namespace MyProject;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hi, using this program you can create 2D-arrays\nPlease enter the amount of columns and rows the array should have");
        Console.WriteLine("Enter the number of rows: ");
        int row = int.Parse(Console.ReadLine()); 
        Console.WriteLine("Enter the number of columns: ");
        int col = int.Parse(Console.ReadLine());
        
        char[,] userDefinedArray = new char[row, col];
        
        Console.WriteLine("You can decide what should be contained in the array\n 1. the indices of the single array elements\n 2. Choose your own character");
        Console.WriteLine("Your choice = ");
        int userDefinedContent = int.Parse(Console.ReadLine());

        int counter = 1;
        char arrayFiller = ' ';
        if (userDefinedContent == 2)
        {
            Console.WriteLine("Please choose the character the array should be filled with: ");
            char userDefinedArrayContent = char.Parse(Console.ReadLine());
            arrayFiller = userDefinedArrayContent;
        }
        else
        {
            arrayFiller = (char)counter;
        }
        for (int rowIndex = 0; rowIndex < row; rowIndex++)
        {
            for (int colIndex = 0; colIndex < col; colIndex++)
            {
                Console.Write("+---+");
            }
            Console.Write("\n");
            for (int colIndex = 0; colIndex < col; colIndex++)
            {
                userDefinedArray[rowIndex, colIndex] = arrayFiller;
                
                Console.Write("| " + userDefinedArray[rowIndex, colIndex] + " |");
                counter++;
            }
            Console.Write("\n");
        }
    }
}