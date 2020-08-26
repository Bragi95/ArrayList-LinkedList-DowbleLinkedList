using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkThree
{
    class Calculate : ActionCalc
    {
        public void Summ()
        {
            double sum;
            int n = Veriable();
            double[] array = new double[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToDouble(EnterNumb());
            }
            sum = Summ(array);
            string str = null;
            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0)
                {
                    str += array[i];
                }
                else
                {
                    str += "+" + array[i];
                }
            }
            str += "=" + sum;
            Console.Write(str);

        }
        public void Deduct()
        {
            int n = Veriable();
            double[] array = new double[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToDouble(EnterNumb());
            }
            double ded = Deduct(array);
            string str = null;
            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0)
                {
                    str += array[i];
                }
                else
                {
                    str += "-" + array[i];
                }
            }
            str += "=" + ded;
            Console.Write(str);

        }
       public void Multiply()
        {
            int n = Veriable();
            double[] array = new double[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToDouble(EnterNumb());
            }
            double ded = Multiply(array);
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
        public void Divide()
        {
            int n = Veriable();
            double[] array = new double[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToDouble(EnterNumb());
            }
            double ded = Divide(array);
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
        public void Calc()
        {
            int con = 0;
            while (con==0)
            {
                string action = Action();

                switch (action)
                {
                    case "+":
                        {
                            Summ();
                            break;
                        }
                    case "-":
                        {
                            Deduct();
                            break;
                        }
                    case "*":
                        {
                            Multiply();
                            break;
                        }
                    case "/":
                        {
                            Divide();
                            break;
                        }
                    case "5":
                        {
                            //Pow();
                            break;
                        }
                    case "6":
                        {
                           // Sqrt();
                            break;
                        }
                    case "7":
                        {
                            con++;
                            break;
                        }
                }
                Console.WriteLine();
            }
        }
    }
}
