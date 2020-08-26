using System;
using System.Collections.Generic;
using System.Text;

namespace Calc
{
    public class calc
    {
        public static int Veriable()
        {
            Console.WriteLine(  "Введите количество переменных");
            int variable = Convert.ToInt32(Console.ReadLine());
            return variable;
        }
        public static double EnterNumb()
        {
            Console.WriteLine("Введите число");
            double number = Convert.ToDouble(Console.ReadLine());
            return number;
        }
       public static int Action()
        {
            Console.WriteLine("Выберите номер действие: 1- сложить, 2- вычесть, 3- умножить, 4- делить, 5- возвести в степень, 6- извлечь корень.");
            int action = Convert.ToInt32(Console.ReadLine());
            return action;
        }
        public static double Summ(double[] array)
        {           
            double sum = 0;
            for (int k = 0; k < array.Length; k++)
            {
                sum += array[k];
            }
            return sum;
        }
        public static double Deduct(double[]array)
        {
            double ded = array[0];
            for (int k = 1; k < array.Length; k++)
            {
                ded -= array[k];
            }
            return ded;            
        }
        public static double Multiply(double[] array)
        {            
            
            double ded = array[0];
            for (int k = 1; k < array.Length; k++)
            {
                ded *= array[k];
            }
            return ded;
        }
        public static double Divide(double[]array)
        {
            double ded = array[0];
            for (int k = 1; k < array.Length; k++)
            {
                ded /= array[k];
            }
            return ded;
        }
        public static double Pow()
        {
            Console.WriteLine("Введите  число: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите степень: ");
            double number2 = Convert.ToDouble(Console.ReadLine());
            var result = Convert.ToInt32(Math.Pow(number1, number2));
            Console.WriteLine("{0} ^ {1} = {2}", number1, number2, result);
            return result;
        }
        public static void Sqrt()
        {
            Console.WriteLine("Введите корень: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            var result = Convert.ToInt32(Math.Sqrt(number1));
            Console.WriteLine("корень числа {0}  = {1}", number1, result);
        }
    }
}
