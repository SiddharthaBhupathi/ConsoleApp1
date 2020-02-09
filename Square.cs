using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs
{
    class pyramid
    {
        static void Main(String[]args)
        {
            {
                int i, j, N;
                string n;
                Console.WriteLine("Enter the value of N");
                n = Console.ReadLine();
                N = Convert.ToInt32(n);
                for (i = 1; i <= N; i++)
                {
                    for (j = 1; j <= N; j++)
                    {
                        Console.Write("*");
                    }
                    Console.Write("\n");
                }

            }
        }
    }
}