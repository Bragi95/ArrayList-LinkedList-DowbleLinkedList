using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkTwo
{
    public class Conditions : HomeWork
    {
        public override string Menu()
        {
            Console.WriteLine("Выберите тему: 1- Квадратное уравнение, 2- Прописная запись числа, 3- Точка круга");
            string menu = Console.ReadLine();
            return menu;
        }
        public double[] NumberOne(double A, double B, double C)
        {      
            double D, X1, X2;
            D = B*B - 4 * A * C;
            if (D > 0)
            {

              X1 = (-B + Math.Sqrt(D)) / (2 * A);
               X2 =Math.Round( (-B - Math.Sqrt(D)) / (2 * A),2);
                return new double[] {X1,X2};
                Console.WriteLine("Имеет два решения");
                Console.WriteLine($"Х1 = {X1}, Х2= {X2}");
            }
            else if (D == 0)
            {
                X1 = (-B + Math.Sqrt(D)) / (2 * A);
                return new double[] { X1 };
                Console.WriteLine("Имеет одно решения");
                Console.WriteLine($"Х1 = {X1}");
            }
            else 
            {
                return new double[] {0d};
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
                        if (num2 == 0)
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
                        if (num1 == 1)
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
        public bool NumberThree(int X, int Y, int r)
        {
             double gipotenuza = Math.Sqrt(X * X + Y * Y);
             if (gipotenuza < Math.Abs(r))
             {
                return true;
               Console.WriteLine($"Точка с координатами ({X},{Y}) принаджелит кругу с радиусом {Math.Abs(r)}");
             }
             else
             {
                return false;
                Console.WriteLine($"Точка с координатами ({X},{Y}) не принаджелит кругу с радиусом {Math.Abs(r)}");
             }
            
        }

    }
}
