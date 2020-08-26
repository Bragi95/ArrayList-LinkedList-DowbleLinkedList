using System;

namespace HomeWorkFour
{
    public class HWFour
    {

        public int Evklid(int var1, int var2)
        {
            if(var1 <=0 || var2 <= 0)
            {
                return 0;
            }
            while (var1!=var2)
            {
                if (var1 > var2)
                {
                    var1 = var1 - var2;
                }
                else
                {
                    var2 = var2 - var1;
                }
            }
            return var2;           
        }


        public int MinArray(int[] array)
        {
            int min = array[0];
           
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i]<min)
                {
                     min = array[i];
                }                
            }
            return min;
        }

        public int MaxArray(int[] array)
        {
            int max = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                      max = array[i];
                }
            }
            return max;
        }


        public int[] SortArray(int[] array)
        {
            
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0+i; j < array.Length; j++)
                {
                    if (array[j] < array[i])
                    {
                        int con = array[i];
                        array[i]= array[j];
                        array[j] = con;
                    }
                }
            }
            return array;
        }
        public double CaloriiInFat(double calorii)
        {
            if(calorii < 0)
            {
                return 0;
            }
            double grammFat = Math.Round(calorii /30,2);
            return grammFat;
        }
        public double SummaAllCaloriyInFat(double travaKg, double vodorosliKg, double crocodailKg)
        {
            if(travaKg<0 || vodorosliKg<0 || crocodailKg<0)
            {
                return 0;
            }
            double summCal = (21 * travaKg) + (32 * vodorosliKg) + (54 * crocodailKg);
            double grammfat= CaloriiInFat(summCal);
            return grammfat;
        }

        public double TotalCaloriesBurnedInGame(double hourPratki, double hourDogon, double hourshahmati, double hourDota)
        {
            if (hourPratki < 0 || hourDogon < 0 || hourshahmati < 0 || hourDota < 0)
            {
                return 0;
            }
            double totalCaloriesBurned = (132 * hourPratki) + (432 * hourDogon) + (67 * hourshahmati) + (0*hourDota);
            return totalCaloriesBurned;
        }
    }
}
