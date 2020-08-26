using System;
using System.IO;

namespace HomeWorkOne
{
    public class HWOne
    {
        public bool SwapVariable(int A, int B)
        {
            int a = A;
            int b = B;
            int c = A;

            A = B;
            B = c;

            if (A == b && B == a)
            {
                return true;
            }
            return false;
        }



        public double FindHipotenuza(double katetA, double katetB)
        {
            double hipo = Math.Sqrt(Math.Pow(katetA, 2) + Math.Pow(katetB, 2));
            return hipo;
        }


        public double SolvingALinearEquation(double A, double B, double C)
        {
            // A* X+B = C
            double X = A / (C - B);
            return X;

        }

        public double ActionProvided(double A, double B)
        {

            if (A > B)
            {
                return (A + B);
            }
            else if (A == B)
            {
                return (A * B);
            }
            else if (A < B)
            {
                return (A - B);
            }
            return 0;
        }

        public double CheckingForDivision(double Var1, double Var2)
        {
            if (Var2 == 0)
            {
                return 0;
            }
            return (Var1 / Var2);
        }


        public int FindQuarter(int X, int Y)
        {
              
              if (X > 0 && Y > 0)
              {
                return 1;
                Console.WriteLine($"X={X}, Y={Y}. I четверть");
              }
              else if (X< 0 && Y> 0)
              {
                return 2;
                Console.WriteLine($"X={X}, Y={Y}.II четверть");
              }
              else if (X< 0 && Y< 0)
              {
                return 3;
                Console.WriteLine($"X={X}, Y={Y}.III четверть");
              }
              else if (X > 0 && Y< 0)
              {
                return 4;
                Console.WriteLine($"X={X}, Y={Y}. IV четверть");
              }
            return 0;

        }





        public void HomeWork()
        {
            int con = 0;
            while (con==0)
            {
                Console.WriteLine("Выберите тему и введите номер: 1- Переменные, 2- Условия. 3- Выход");
                int action1 = Convert.ToInt32(Console.ReadLine());

                switch (action1)
                {
                    case 1:
                        {
                            Console.WriteLine("Выберите номер задачи: 1-Поменяйте содержимое переменных a и b местами. , 2- Найти длину гипотенузы, 3- Решение линейного уровнения ");
                            int action = Convert.ToInt32(Console.ReadLine());
                            if (action == 1)
                            {
                                Console.WriteLine("Введите значение переменной а: ");
                                int A = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Введите значение переменной b:");
                                int B = Convert.ToInt32(Console.ReadLine());

                                int c = A;

                                A = B;
                                B = c;

                                Console.WriteLine($"A= {A}");
                                Console.WriteLine($"B= {B}");
                            }
                            else if (action == 2)
                            {
                                Console.WriteLine("Введите длину катета а: ");
                                double katetA = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Введите длину катета b:");
                                double katetB = Convert.ToInt32(Console.ReadLine());

                                double hypo = Math.Sqrt(Math.Pow(katetA, 2) + Math.Pow(katetB, 2));

                                Console.WriteLine($"Гипотенуза = {hypo}");
                            }
                            else if (action == 3)
                            {
                                Console.WriteLine("A*X+B=C");
                                Console.WriteLine("Введите первую переменную: ");
                                double A = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Введите вторую переменную:");
                                double B = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Введите третью переменную:");
                                double C = Convert.ToInt32(Console.ReadLine());

                                double X = A / (C - B);
                                Console.WriteLine($"X = {X}");
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Выберите номер задачи: 1- работа с if/else , 2- проверка на деление, 3- определить четверть ");
                            int action = Convert.ToInt32(Console.ReadLine());
                            if (action == 1)
                            {
                                Console.WriteLine("Если A>B, подсчитать A+B, если A=B, подсчитать A*B, если A<B, подсчитать A-B");
                                Console.WriteLine("Введите значение переменной а: ");
                                int A = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Введите значение переменной b:");
                                int B = Convert.ToInt32(Console.ReadLine());

                                if (A > B)
                                {
                                    Console.WriteLine(A + B);
                                }
                                else if (A == B)
                                {
                                    Console.WriteLine(A * B);
                                }
                                else if (A < B)
                                {
                                    Console.WriteLine(A - B);
                                }
                            }
                            else if (action == 2)
                            {
                                Random rand = new Random();

                                double var1 = rand.Next(-100, 100);
                                double var2 = rand.Next(-100, 100);

                                if ((var1 / var2) == 0)
                                {
                                    Console.WriteLine("Не делится так как одно из значений равно 0");
                                }
                                else if ((var1 / var2) != 0)
                                {
                                    Console.WriteLine($"Первая переменная = {var1}, Вторая переменная = {var2}. Данные переменные делятся, их результат {var1 / var2} и остаток равен {(var1 / var2) % 10}");
                                }
                            }
                            else if (action == 3)
                            {
                                Random rand = new Random();

                                int X = rand.Next(-100, 100);
                                int Y = rand.Next(-100, 100);

                                if (X > 0 && Y > 0)
                                {
                                    Console.WriteLine($"X={X}, Y={Y}. I четверть");
                                }
                                else if (X < 0 && Y > 0)
                                {
                                    Console.WriteLine($"X={X}, Y={Y}.II четверть");
                                }
                                else if (X < 0 && Y < 0)
                                {
                                    Console.WriteLine($"X={X}, Y={Y}.III четверть");
                                }
                                else if (X > 0 && Y < 0)
                                {
                                    Console.WriteLine($"X={X}, Y={Y}. IV четверть");
                                }
                            }
                            break;
                        }
                    case 3:
                        {
                            con++;
                            break;
                        }
                }
            }
        }
    }
}
