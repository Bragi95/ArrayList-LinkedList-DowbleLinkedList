using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkThree
{
     public class ActionCalc
    {
        public  int Veriable()
        {
            Console.WriteLine("Введите количество переменных");
            int variable = Convert.ToInt32(Console.ReadLine());
            return variable;
        }
        public  double EnterNumb()
        {
            Console.WriteLine("Введите число");
            double number = Convert.ToDouble(Console.ReadLine());
            return number;
        }
        public  string Action()
        {
            Console.WriteLine("Выберите действие: +, -, *, /, 5- возвести в степень, 6- извлечь корень, 7- Выйти");
            string action = Console.ReadLine();
            return action;
        }
        public  double Summ(double[] array)
        {
            double sum = 0;
            for (int k = 0; k < array.Length; k++)
            {
                sum += array[k];
            }
            return sum;
        }
        public  double Deduct(double[] array)
        {
            double ded = array[0];
            for (int k = 1; k < array.Length; k++)
            {
                ded -= array[k];
            }
            return ded;
        }
        public  double Multiply(double[] array)
        {

            double ded = array[0];
            for (int k = 1; k < array.Length; k++)
            {
                if (array[k] != 0)
                {
                    ded *= array[k];
                }
                else
                {
                    return 0;
                }                
            }
            return ded;
        }
        public  double Divide(double[] array)
        {
            double ded = array[0];
            for (int k = 1; k < array.Length; k++)
            {
                if (array[k] != 0)
                {
                    ded /= array[k];
                }
                else
                {
                    return 0;
                }
            }
            return ded;
        }
        public  double Pow(double number1, double number2)
        {
            /*Console.WriteLine("Введите  число: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите степень: ");
            double number2 = Convert.ToDouble(Console.ReadLine());
            */
            var result = Convert.ToInt32(Math.Pow(number1, number2));
            //Console.WriteLine("{0} ^ {1} = {2}", number1, number2, result);
            return result;
        }
        public  double Sqrt(double number1)
        {
           // Console.WriteLine("Введите корень: ");
           // double number1 = Convert.ToDouble(Console.ReadLine());
            double result = Convert.ToDouble(Math.Sqrt(number1));
            return result;
            //Console.WriteLine("корень числа {0}  = {1}", number1, result);
        }
    }
}
