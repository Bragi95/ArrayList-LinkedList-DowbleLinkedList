using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkThree
{
    public class NestedCycles : HW
    {
        public void TaskNestedCycles()
        {
            Console.WriteLine("Выберите задачу: 1-Кол-во цифр в числе , 2- Рисунок из символов");
            int menu = Convert.ToInt32(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    {
                        //SameNumber();
                        break;
                    }
                case 2:
                    {
                        PictureSymbols();
                        break;
                    }
            }
        }

        public int SameNumber(int firstVar, int secondVar)
        {
           
           // int copySecondVar = secondVar;
            int con=0;
           
                while (secondVar > 0)
                {
                    if (firstVar== secondVar%10)
                    {
                        con++;
                    }
                    secondVar /= 10;
                }
            return con;
            //Console.WriteLine($"Колличество {firstVar} в числе {copySecondVar} = {con}");
        }
        public void PictureSymbols()
        {
            Console.WriteLine("Enter outside symbol: ");
            string firstSym = Console.ReadLine();
            Console.WriteLine("Enter inside symbol: ");
            string secondSym = Console.ReadLine();
            Console.WriteLine("Enter size line: ");
            int sizeX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter quantity line: ");
            int sizeY = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < sizeY; i++)
            {                    
                for (int j = 0; j < sizeX; j++)
                {                    
                    if (i==0 || i==sizeY-1)
                    Console.Write(firstSym);
                    else if(j==0 || j==sizeX-1)
                    {
                     Console.Write(firstSym);
                    }
                    else
                    {
                        Console.Write(secondSym);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
