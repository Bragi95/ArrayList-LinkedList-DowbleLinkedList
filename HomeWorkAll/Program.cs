using HomeWorkOne;
using HomeWorkThree;
using HomeWorkTwo;
using HWLinkedList;
using System;
using LinkedListTwo;


namespace HomeWorkAll
{
    class Program
    {
        static void Main(string[] args)
        {
            LListTwo lList = new LListTwo();
           
            lList.AddLast(new int[] {1,2,3,4,5,6});
            

            lList.Print();
            Console.WriteLine();

            lList.RemoveLast();
           

            lList.Print();

            Console.WriteLine();

           // lList.PrintRevers();


            #region
            //LinkedList linked = new LinkedList();
            //linked.AddFirst(10);
            //linked.AddLast(13);
            //linked.AddFirst(12);
            //linked.AddLast(30);
            //linked.AddLast(new int[] { 1, 5, 4, 34 });
            //linked.AddAt(4, 100);
            //linked.AddAt(8, 100);
            //linked.AddAt(0, 6897);


            ////linked.RemoveFirst();

            //linked.Print();

            //    //linked.RemoveAll();

            //Console.WriteLine();

            //linked.Reverse();
            //linked.Print();
            //Console.WriteLine();
            //linked.Print();
            //Console.WriteLine();
            //linked.Sort();
            //linked.Print();
            //Console.WriteLine();
            //linked.SortDesc();
            //linked.Print();
            #endregion
            //int con = 0;
            //while (con == 0)
            //{
            //    Console.WriteLine("Выберите домашнее задание: 1- HomeWokr №1, 2- HomeWokr №2, 3- HomeWokr №3. 4- Закончить проверку ДЗ");
            //    int menu = Convert.ToInt32(Console.ReadLine());

            //    switch (menu)
            //    {
            //        case 1:
            //            {
            //                HWOne hwOne = new HWOne();
            //                hwOne.HomeWork();

            //                break;
            //            }
            //        case 2:
            //            {
            //                HomeWork homeWork = new HomeWork();
            //                homeWork.HW2();
            //                break;
            //            }
            //        case 3:
            //            {
            //                HW homeWork3 = new HW();
            //                homeWork3.Menu();
            //                break;
            //            }
            //        case 4:
            //            {
            //                con++;
            //                break;
            //            }
            //   }
            // }
        }
    }
}
