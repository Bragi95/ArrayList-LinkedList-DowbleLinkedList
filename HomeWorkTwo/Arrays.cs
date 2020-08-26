using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace HomeWorkTwo
{
   public class Arrays
    {
        public int MaxValueArray(int[] array)
        {
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
           // Console.WriteLine($" Максимальное значение: {max}");
        }
        public int SummOddElementArray(int[] array)
        {
            int sumwithnechet = 0;
            for (int i = 1; i < array.Length; i+=2)
            {
                sumwithnechet += array[i];                
            }
            return sumwithnechet;
            //Console.WriteLine($"Сумма всех значений массива с нечетным индексом: {sumwithnechet}");
        }
        public List<int> SummElementLessAVG(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            int midsum = sum / array.Length;
            //Console.WriteLine($"Значения элементов массива, которые меньше среднего арифметического: {midsum}");

            List<int> result = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < midsum)
                {
                     result.Add(array[i]);
                    //Console.Write(array[i] + " ");
                }
            }
            return result;
        }
        public void ReversArray(int[] array)
        {
            int j;
            for (int i = 0; i < array.Length / 2; i++)
            {
                j = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = array[i];
                array[i] = j;
            }          
        }
        public void TasksArray()
        {
            Random random = new Random();

            int[] array = new int[20];
            Console.WriteLine("Массив");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-100, 100);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            MaxValueArray(array);

            SummOddElementArray(array);

            SummElementLessAVG(array);
            
            Console.WriteLine();
            Console.WriteLine("Реверс массива:");
            // Array.Reverse(array);
            int j;
            for (int i = 0; i < array.Length / 2; i++)
            {
                j = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = array[i];
                array[i] = j;
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
