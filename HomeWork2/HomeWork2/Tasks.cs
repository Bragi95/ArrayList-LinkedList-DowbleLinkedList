using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork2
{
    class Tasks
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
    }
}
