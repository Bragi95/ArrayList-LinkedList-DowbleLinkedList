using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkThree
{
    public class OneArray : HW
    {
        public int[] ReversArray(int[] array)
        {
            if (array.Length % 2 > 0)
            {
                for (int i = 0; i < array.Length / 2; i++)
                {
                    int q = array[array.Length / 2 + i + 1];
                    array[array.Length / 2 + i + 1] = array[i];
                    array[i] = q;
                }
            }
            else
            {
                for (int i = 0; i < array.Length / 2; i++)
                {
                    int q = array[array.Length / 2 + i];
                    array[array.Length / 2 + i] = array[i];
                    array[i] = q;
                }
                
            }
            return array;
        }

        public void MinMaxElArray(int[] array)
        {
            int Max = array[0];
            int Min = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > Max)
                {
                    Max = array[i];
                }

                if (array[i] < Min)
                {
                    Min = array[i];
                }
            }
            Console.WriteLine($" Max= {Max}, Min= {Min}");
        }
        public int SummDigitBetweenMinAndMax(int Max,int Min, int[] array)
        {            
            int con = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == Max || array[i] == Min)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[j] == Max || array[j] == Min)
                        {
                            break;
                        }
                        else
                        {
                            con += array[j];
                        }
                    }
                }
                else if (con > 0)
                {
                    break;
                }
            }
            return con;
            //Console.WriteLine($"Сумма элементов массива между {Min} и {Max} = {con}");
        }
        public void TaskArrayOne()        
        {
            Console.WriteLine("Enter lenght array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 100);
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
            if (array.Length % 2 > 0)
            {
                for (int i = 0; i < array.Length / 2; i++)
                {
                    int q = array[array.Length / 2 + i + 1];
                    array[array.Length / 2 + i + 1] = array[i];
                    array[i] = q;
                }
            }
            else
            {
                for (int i = 0; i < array.Length / 2; i++)
                {
                    int q = array[array.Length / 2 + i];
                    array[array.Length / 2 + i] = array[i];
                    array[i] = q;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            int Max =array[0] ;
            int Min =array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > Max)
                {
                    Max = array[i];
                }
                
                if(array[i] < Min)
                {
                    Min = array[i];
                }
            }
            Console.WriteLine($" Max= {Max}, Min= {Min}");
            int con = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i]==Max || array[i] == Min)
                {
                    for (int j = i+1; j < array.Length; j++)
                    {
                        if (array[j] == Max || array[j] == Min)
                        {
                            break;
                        }
                        else
                        {
                            con += array[j];
                        }
                    }                  
                }
                else if(con>0)
                {
                    break;
                }                
            }
            Console.WriteLine($"Сумма элементов массива между {Min} и {Max} = {con}");
        }
    }
}
