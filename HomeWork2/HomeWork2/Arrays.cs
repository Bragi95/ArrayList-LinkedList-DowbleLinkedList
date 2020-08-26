using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork2
{
    class Arrays : Tasks
    {
        public void TasksArray()
        {
            Random random = new Random();
            
            int[] array = new int[20];
            Console.WriteLine("Массив");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-100, 100);
                Console.Write(array[i]+" ");
            }
            Console.WriteLine();
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i]>max)
                {
                    max = array[i];
                }                
            }
            Console.WriteLine($" Максимальное значение: {max}");
            int sumwithnechet = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int ost = i % 2;
                if (ost > 0)
                {
                    sumwithnechet += array[i];
                }
            }
            Console.WriteLine($"Сумма всех значений массива с нечетным индексом: {sumwithnechet}");
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            int midsum = sum / array.Length;
            Console.WriteLine($"Значения элементов массива, которые меньше среднего арифметического: {midsum}");
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]<midsum)
                {
                    Console.Write(array[i]+" ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Реверс массива:");
           // Array.Reverse(array);
            int j;
            for (int i = 0; i < array.Length/2; i++)
            {
                j = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = array[i];
                array[i] = j;               
            }
            for (int i = 0; i < array.Length; i++)
            {
              Console.Write(array[i]+" ");
            }
            Console.WriteLine();
        }
    }
}
