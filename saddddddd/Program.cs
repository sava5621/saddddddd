using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CrossProject
{
    // Трехмерные массивы

    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
           
            int[][][] someArray = new int[random.Next(3, 6)][][];
            for (int i = 0; i < someArray.Length; i++)
            {
                someArray[i] = new int[random.Next(2, 6)][];

                for (int j = 0; j < someArray.Length; j++)
                {
                    someArray[i][j] = new int[random.Next(2, 6)];

                    for (int a = 0; a < someArray.Length; a++)
                    {
                        someArray[i][j][a] = random.Next(100);
                    }
                }
            }

            for (int i = 0; i < someArray.Length; i++)
            {
                WriteLine("Page N':" + (i + 1));
                for (int j = 0; j < someArray.Length; j++)
                {
                    for (int a = 0; a < someArray.Length; a++)
                    {
                        WriteLine(someArray[i][j][a] + " ");
                    }
                    WriteLine();
                }
                WriteLine();
            }
            ReadLine();
        }
    }
}