using System;

namespace Retreive
{
    class retreive
    {
        public static void getMultiples(int x, int y)
        {
            int[] groups = new int[99];
            int[] iterator = new int[99];
            int z;
            for (int i = 1; i <= y; i++)
            {
                z = x*i;
                //Console.WriteLine(z);
                groups[i] = z;
                iterator[i] = i;
                Console.WriteLine("({0}, {1})", iterator[i], groups[i]);
            }
        }
    }
}
