using System;


namespace HomeWorkThree
{
    public class HW
    {
        public int EnterVariable()
        {
            Console.WriteLine("Enter variable: ");
            int menu = Convert.ToInt32(Console.ReadLine());
            return menu;
        }

        public void Menu()
        {
            int con=0;
            while (con == 0)
            {
                Console.WriteLine("Выберите тему: 1- Циклы, 2- Вложенные Циклы, 3- Одномерный массив, 4- Двумерный массив, 5- Калькулятор.6- Выход в меню ДЗ");
                int menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        {
                            Cycles cycles = new Cycles();
                            cycles.TaskCycles();
                            break;
                        }
                    case 2:
                        {
                            NestedCycles nestedCycles = new NestedCycles();
                            nestedCycles.TaskNestedCycles();
                            break;
                        }
                    case 3:
                        {
                            OneArray oneArray = new OneArray();
                            oneArray.TaskArrayOne();
                            break;
                        }
                    case 4:
                        {
                            TwoArray twoArray = new TwoArray();
                            twoArray.TaskArrayTwo();
                            break;
                        }
                    case 5:
                        {
                            Calculate calculate = new Calculate();
                            calculate.Calc();
                            break;
                        }
                    case 6:
                        {
                            con++;
                            break;
                        }
                }
            }
        }
    }
}
