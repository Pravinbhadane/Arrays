using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    public class Two_D_Array
    {
        static void Main(string[] args)
        {
            int[,] arr1 = new int[3, 3];
            Console.WriteLine("Enter 1st matrix Values");

            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    arr1[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

                    for (int i = 0; i < arr1.GetLength(0); i++)
                    {
                        for (int j = 0; j < arr1.GetLength(1); j++)
                        {
                            Console.Write(arr1[i,j] + " ");
                        }
                        Console.WriteLine();
                    }


            int[,] arr2 = new int[3, 3];
            Console.WriteLine("Enter 2nd matrix Values");

            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

                    for (int i = 0; i < arr2.GetLength(0); i++)
                    {
                        for (int j = 0; j < arr2.GetLength(1); j++)
                        {
                            Console.Write(arr2[i, j] + " ");
                        }
                        Console.WriteLine();
                    }

            Console.WriteLine("Addition of Matrix");


            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    Console.Write(arr2[i, j] + arr1[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
