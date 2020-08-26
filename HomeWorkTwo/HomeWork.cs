using System;

namespace HomeWorkTwo
{
    public class HomeWork
    {
        public virtual string Menu()
        {
            Console.WriteLine("Выберите тему: 1- Условия, 2- Циклы, 3-Массивы 4-Закрыть программу  ");
            string menu = Console.ReadLine();
            return menu;
        }
        protected double EnterVariable()
        {
            Console.Write("Enter variable: ");
            double vrb = Convert.ToDouble(Console.ReadLine());
            return vrb;
        }
        public void HW2()
        {
            
            Arrays arrays = new Arrays();
            Cycles cycles = new Cycles();
            Conditions conditions = new Conditions();
            int w = 0;
            while (w == 0)
            {
                string menu = Menu();

                switch (menu)
                {
                    case "1":
                        {
                            int i = 0;
                            while (i == 0)
                            {
                                string tas = conditions.Menu();
                                if (tas == "1")
                                {
                                    //conditions.NumberOne();
                                    i++;
                                }
                                else if (tas == "2")
                                {
                                    conditions.NumberTwo();
                                    i++;
                                }
                                else if (tas == "3")
                                {
                                    //conditions.NumberThree();
                                    i++;
                                }
                                else
                                {
                                    Console.WriteLine("Такой задачи нету, еще раз выбери!");
                                }
                            }

                            break;
                        }
                    case "2":
                        {
                            int i = 0;
                            while (i == 0)
                            {
                                string tas = cycles.Menu();
                                if (tas == "1")
                                {
                                    //cycles.NumberOne();
                                    i++;
                                }
                                else if (tas == "2")
                                {
                                    //cycles.NumberTwo();
                                    i++;
                                }
                                else if (tas == "3")
                                {
                                    //cycles.NumberThree();
                                    i++;
                                }
                                else if (tas == "4")
                                {
                                    //cycles.NumberFour();
                                    i++;
                                }
                                else if (tas == "5")
                                {
                                    //cycles.NumberFive();
                                    i++;
                                }
                                else
                                {
                                    Console.WriteLine("Такой задачи нету, еще раз выбери!");
                                }
                            }
                            break;
                        }
                    case "3":
                        {
                            arrays.TasksArray();
                            break;
                        }
                    case "4":
                        {
                            w++;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Херню нажали, написано же (1,2,3 или 4). Пробуй еще раз, ты справишься!!!");
                            break;
                        }
                }
            }
        }
    }
    }

