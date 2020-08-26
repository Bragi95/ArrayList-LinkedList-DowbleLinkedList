using System;

namespace Calc
{
    public class Program
    {      
        static void Summ()
        {
            
            double sum ;
            int n = calc.Veriable();
            double[] array = new double[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToDouble(calc.EnterNumb());
            }
           sum= calc.Summ(array);
            string str=null;
            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0)
                {
                    str += array[i];
                }
                else
                {
                    str +="+"+ array[i];
                }
            }
            str+="="+sum;
            Console.Write(str);
           
        }
        static void Deduct()
        {                       
            int n = calc.Veriable();
            double[] array = new double[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToDouble(calc.EnterNumb());
            }            
            double ded=calc.Deduct(array);
            string str = null;
            for (int i = 0; i < array.Length; i++)
            { 
                if (i == 0)
                {
                    str += array[i];
                }
                else
                {
                    str += "-" +array[i];
                }
            }
            str += "=" + ded;
                Console.Write(str);
          
        }
        static void Multiply()
        {            
            int n = calc.Veriable();
            double[] array = new double[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToDouble(calc.EnterNumb());
            }
            double ded = calc.Multiply(array);
            string str = null;
            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0)
                {
                    str += array[i];
                }
                else
                {
                    str += "*" + array[i];
                }
            }
            str += "=" + ded;
            Console.Write(str);
        }
        static void Divide()
        {
            int n = calc.Veriable();
            double[] array = new double[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToDouble(calc.EnterNumb());
            }
            double ded = calc.Divide(array);
            string str = null;
            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0)
                {
                    str += array[i];
                }
                else
                {
                    str += "/" + array[i];
                }
            }
            str += "=" + ded;
            Console.Write(str);
        }
        
        static void Main()
        {
            while (true)
            {
                int action = calc.Action();
                               
                if (action > 6)
                {
                    Console.WriteLine("Вы выбрали неверное действие!!");
                }
                switch (action)
                {
                    case 1:
                        {
                            Summ();
                            break;
                        }
                    case 2:
                        {
                            Deduct();
                            break;
                        }
                    case 3:
                        {
                            Multiply();
                            break;
                        }
                    case 4:
                        {
                            Divide();
                            break;
                        }
                    case 5:
                        {
                            calc.Pow();
                            break;
                        }
                    case 6:
                        {
                            calc.Sqrt();
                            break;
                        }                        
                }
                Console.WriteLine();
            }
        }
    }
}
               


            


        
