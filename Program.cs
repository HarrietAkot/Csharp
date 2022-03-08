using System;

namespace MyApplication
{
    class Program
    {
        static void Main()
        {
            int[][] a = new int[3][];

            Console.WriteLine("Enter size of first array");
            a[0] = new int[int.Parse(Console.ReadLine())];
            Console.WriteLine("Enter size of second array");
            a[1] = new int[int.Parse(Console.ReadLine())];
            Console.WriteLine("Enter size of third array");
            a[2] = new int[int.Parse(Console.ReadLine())];
            int s = 0;
            Console.WriteLine("Enter Jagged Array Elements");
            for (int i = 0; i < 3; i++)
            {
                if (a[i] != null)
                {
                    for (int j = 0; j < a[i].Length; j++)
                    {
                        a[i][j] = int.Parse(Console.ReadLine());
                        s = s + a[i][j];
                    }
                }
            }
            Console.WriteLine("Total sum of Elements is {0}", s);


        }
    }
}