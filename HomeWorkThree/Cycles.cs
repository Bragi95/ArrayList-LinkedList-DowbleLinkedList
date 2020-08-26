using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace HomeWorkThree
{
    public class Cycles : HW
    {
        public void TaskCycles()
        {
            Console.WriteLine("Выберите задачу: 1- Сравнение двух цисел, 2- Число на оборот");
            int menu = Convert.ToInt32(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    {
                        //SameDigit();
                        break;
                    }
                case 2:
                    {
                       // TwoTask();
                        break;
                    }
            }
        }
    public bool SameDigit(int firstVar, int secondVar)
        {            
            //int firstVar = EnterVariable();
            //int secondVar = EnterVariable();

            while(firstVar>0)
            {
                while (secondVar > 0)
                {
                    if(firstVar%10==secondVar%10)
                    {
                       // Console.WriteLine("DA");
                        return true;
                    }                                       
                    secondVar /= 10;                    
                }
                firstVar /= 10;
            }
            return false;
            //Console.WriteLine("Net");

            /*
            if (firstVar / 100 == secondVar / 100)
            {
                Console.WriteLine("Da");
            }
            else if (firstVar / 10 % 10 == secondVar / 10 % 10)
            {
                Console.WriteLine("Da");
            }
            else if (firstVar % 100 == secondVar % 100)
            {
                Console.WriteLine("Da");
            }
            else
            {
                Console.WriteLine("NET");
            }  
            */

            /*
            string firstVar = EnterVariable().ToString();
            string secondVar = EnterVariable().ToString();

            for (int i = 0; i < firstVar.Length; i++)
            {
                for (int j = 0; j < secondVar.Length; j++)
                {
                    if (firstVar[i] == secondVar[j])
                    {
                        Console.WriteLine("Da");
                    }

                }
            }
            Console.WriteLine("Net");
            */


        }
        public List<int> TwoTask(int Var)
        {
            List<int> array = new List<int>();


            while (Var>0)
            {
                array.Add(Var %10);
               Var /= 10;

            }
            return array;
            /*
            for (int i = 0; i < 1; i++)
            {
                if (var.ToString().Length > 3)
                {                   
                    Console.WriteLine(var % 1000);
                    Console.Write(var / 10 % 10);
                    Console.Write(var / 100 % 10);
                    Console.Write(var / 1000);
                    
                }
                else if(var.ToString().Length > 2)
                {
                    Console.Write(var % 10);
                    Console.Write(var / 10 % 10);
                    Console.Write(var / 100);                   
                }
                else if (var.ToString().Length > 1)
                {
                    Console.Write(var % 10);
                    Console.Write(var / 10);                    
                    
                }
            }
            */
        }      

    }
}
