using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkTwo
{
     public class Cycles : HomeWork
    {
        public override string Menu()
        {
            Console.WriteLine("Выберите задачу: 1- Возвести число A в степень B, 2- Вывести все числа от 1 до 1000, которые делятся на A, 3-Доказать, что 1+2+...+n = n*(n+1)/2, 4-Фибоначчи, 5-Наибольший делитель  ");
            string menu = Console.ReadLine();
            return menu;
        }

        public double NumberOne(double A, double B)
        {           
            double res = 1;

            for (int i = 0; i < B; i++)
            {
                res = res * A;
            }
            return res;
            Console.WriteLine($" {A} в степени {B} равно {res}");
        }
        public List<double> NumberTwo(double A)
        {
            double a = Math.Abs(A);
            List<double> result = new List<double>();
            if (A==0)
            {
                return new List<double> {};
            }
            
            for (int i = (int)a; i >=1; i--)
            {               
                if (a % i == 0 && i != a)
                {
                    result.Add(a / i);
                    //Console.WriteLine($"Максимальный делитель {i}. {A} / {i} = {A / i}");
                    
                }
            }
            return result;
        }
        public bool NumberThree(int N)
        {
           
            double res = 0;
            double res2;
            for (int i = 1; i <= N; i++)
            {
                res += i;
            }
            res2 = N * (N + 1) / 2;
            if (res == res2)
            {
                return true;
                Console.WriteLine($"Сумму всех чисел до n равна {res}, n*(n+1)/2 равно{res2}");
            }
            return false;
        }
        public double[] NumberFour(int N)
        {
            
            double a = 1;
            double fibo = 0;
            double[] arrayResult = new double[N];
            double b;
            for (int i = 0; i < N; i++)
            {
                b = a;
                a = fibo;
                fibo += b;
                arrayResult[i] = fibo;
                //Console.WriteLine(fibo);
            }
            return arrayResult;
        }
        public double NumberFive(double A)
        {
                     
            for (double i = A - 1; i > 0; i--)
            {                
                if (A % i == 0)
                {
                    return i;
                    Console.WriteLine($"Максимальный делитель:{i}");
                    break;
                }

            }
            return 0;
        }
    }
}
