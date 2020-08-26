using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork2
{
    class Cycles : Tasks
    {
        public override string Menu()
        {
            Console.WriteLine("Выберите задачу: 1- Возвести число A в степень B, 2- Вывести все числа от 1 до 1000, которые делятся на A, 3-Доказать, что 1+2+...+n = n*(n+1)/2, 4-Фибоначчи, 5-Наибольший делитель  ");
            string menu = Console.ReadLine();
            return menu;
        }

        public void NumberOne()
        {
            double A = EnterVariable();
            double B = EnterVariable();
            double res = 0;

            for (int i = 0; i < B; i++)
            {
                res += A * A;
            }
            Console.WriteLine($" {A} в степени {B} равно {res}");
        }
        public void NumberTwo()
        {
            double A = EnterVariable();
            double res;
            for (int i = 1000; i >1 ; i--)
            {
                
                res = A % i;
                if (res == 0 && i!=A)
                {
                    Console.WriteLine($"Максимальный делитель {i}. {A} / {i} = {A / i}");
                    break;
                }
            }
        }
        public void NumberThree()
        {
            double N = EnterVariable();
            double res=0;
            double res2;
            for (int i = 1; i < N; i++)
            {
                res += i;
            }

            res2 = N*(N + 1) / 2;
            if (res == res2)
            {
                Console.WriteLine($"Сумму всех чисел до n равна {res}, n*(n+1)/2 равно{res2}");
            }
        }
        public void NumberFour()
        {
            double N = EnterVariable();
            double a = 0;
            double fibo=1;
            double b;
            for (int i = 0; i < N; i++)
            {
                b = a;
                a = fibo;
                fibo += b;               
                Console.WriteLine(fibo);
            }
        }
        public void NumberFive()
        {
            double A = EnterVariable();
            double res;
            for (double i = A-1; i > 0; i--)
            {
                res = A % i;
                if (res == 0)
                {
                    Console.WriteLine($"Максимальный делитель:{i}");
                    break;
                }
                
            }
        }
    }
}
