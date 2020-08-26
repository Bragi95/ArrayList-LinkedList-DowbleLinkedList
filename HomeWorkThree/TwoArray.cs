using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkThree
{
    public class TwoArray : HW
    {
        public int FindPointArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i - 1 >= 0 && i <= array.GetLength(0) - 1 && j - 1 >= 0 && j <= array.GetLength(1) - 1)
                    {
                        if ((array[i, j] > array[i - 1, j]) &&
                            (array[i, j] > array[i + 1, j]) &&
                            (array[i, j] > array[i, j - 1]) &&
                            (array[i, j] > array[i, j + 1]))
                        {
                            int a = array[i, j];
                            return a;
                            //Console.WriteLine($"[{i},{j}] = {array[i, j]}");

                        }
                    }
                }
            }
            return 0;
        }
        public void TaskArrayTwo() 
        {
            Console.WriteLine("Enter lenght array: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter lenght array: ");
            int cols = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int[,] array = new int[rows, cols];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {                    
                    array[i, j] = random.Next(-200, 200);                    
                }                
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {                    
                        Console.Write(array[i,j]+"\t");                   
                }
                Console.WriteLine();
            }

            FindPointArray(array);
        }    
    }
}
