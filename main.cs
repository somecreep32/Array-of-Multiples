using System;
using Retreive;

class multi 
{
    static int x;
    static int y;
    
    public static int Main() 
    {
        Console.WriteLine("Type the number: ");
        if (int.TryParse(Console.ReadLine(), out x))
        {
            Console.WriteLine("x set");
            Console.WriteLine("Type the number of multiples: ");
            if (int.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("y set");
                Retreive.retreive.getMultiples(x, y);
            }
            else
            {
                Console.WriteLine("Please write a number: ");
            }
        }
        else
        {
            Console.WriteLine("Please enter a number: ");
        }
        return 0;
    }
}
