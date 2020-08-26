using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace HomeWork2
{
    class Conditions : Tasks
    {
        public override string Menu()
        {
            Console.WriteLine("Выберите тему: 1- Квадратное уравнение, 2- Прописная запись числа, 3- Точка круга");
            string menu = Console.ReadLine();
            return menu;
        }
        public void NumberOne()
        {
            double A = EnterVariable();
            double B = EnterVariable();
            double C = EnterVariable();
            double D, X1, X2;
            D = Math.Pow(B, 2) - 4 * A * C;
            if(D>0)
            {
                X1 = (-B + Math.Sqrt(D)) / 2 * A;
                X2 = (-B - Math.Sqrt(D)) / 2 * A;
                Console.WriteLine("Имеет два решения");
                Console.WriteLine($"Х1 = {X1}, Х2= {X2}");
            }
            else if (D==0)
            {
                X1 = (-B + Math.Sqrt(D)) / 2 * A;
                Console.WriteLine("Имеет одно решения");
                Console.WriteLine($"Х1 = {X1}");
            }
            else if (D < 0)
            {
                Console.WriteLine("Квадратное уравнение не имеет решения");
            }            
        }
        public void NumberTwo()
        {
             int vrb = Convert.ToInt32(EnterVariable());
            int num1 = vrb / 10;
            int num2 = vrb % 10;
            
            switch (num1)
            {
                case 1:
                    {
                        if(num2==0)
                        Console.Write("Десять ");              

                        break;
                    }
                case 2:
                    {
                        Console.Write("Двадцать ");

                        break;
                    }
                case 3:
                    {                        
                        Console.Write("Тридцать ");
                        break;
                    }
                case 4:
                    {
                        Console.Write("Сорок ");
                        break;
                    }
                case 5:
                    {
                        Console.Write("Пятдесят ");
                        break;
                    }
                case 6:
                    { 
                        Console.Write("Шестьдесят ");
                        break;
                    }
                case 7:
                    {
                        Console.Write("Семьдесят ");
                        break;
                    }
                case 8:
                    {
                        Console.Write("Восемьдесят ");
                        break;
                    }               
                case 9:
                    {
                        Console.Write("Девяносто ");
                        break;
                    }                    
            }
            switch (num2)
            {
                case 1:
                    {
                        if(num1==1)
                            Console.WriteLine("Одинадцать");
                        else
                            Console.Write("Один");

                        break;
                    }
                case 2:
                    {
                        if (num1 == 1)
                            Console.WriteLine("Двенадцать");
                        else
                            Console.Write("Два");

                        break;
                    }
                case 3:
                    {
                        if (num1 == 1)
                            Console.WriteLine("Тринадцать");
                        else
                            Console.Write("Три");
                        break;
                    }
                case 4:
                    {
                        if (num1 == 1)
                            Console.WriteLine("Четырнадцать");
                        else
                            Console.Write("четыре");
                        break;
                    }
                case 5:
                    {
                        if (num1 == 1)
                            Console.WriteLine("Пятнадцать");
                        else
                            Console.Write("Пять");
                        break;
                    }
                case 6:
                    {
                        if (num1 == 1)
                            Console.WriteLine("Шеснадцать");
                        else
                            Console.Write("Шесть");
                        break;
                    }
                case 7:
                    {
                        if (num1 == 1)
                            Console.WriteLine("Семьнадцать");
                        else
                            Console.Write("Семь");
                        break;
                    }
                case 8:
                    {
                        if (num1 == 1)
                            Console.WriteLine("Восемьнадцать");
                        else
                            Console.Write("Восемь");
                        break;
                    }
                case 9:
                    {
                        if (num1 == 1)
                            Console.WriteLine("О");
                        else
                            Console.Write("Девять");
                        break;
                    }                    
            }
            Console.WriteLine();
        }
        public void NumberThree()
        {
            Random random = new Random();
            int X = random.Next(-15, 15);
            int Y = random.Next(-15, 15);            
            int i = 0;
            while (i == 0)
            {
                int r = random.Next(-10, 10);
                if (r > 0 || r < 0)
                {
                    if (Math.Abs(X) <= Math.Abs(r) && Math.Abs(Y) <= Math.Abs(r))
                    {
                        Console.WriteLine($"Точка с координатами ({X},{Y}) принадлежит кругу с радиусом {r}");
                    }
                    else
                    {
                        Console.WriteLine($"Точка с координатами ({X},{Y}) не принадлежит кругу с радиусом {r}");
                    }
                    i++;
                }                
            }
        }
    }
}
