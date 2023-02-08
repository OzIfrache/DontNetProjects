using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.CommonTypes
{
    public class ArraysAndLoops
    {

        public static void Run()
        {
            //ListIterations();

            ShowMenu();
        }

        public static void ListIterations()
        {
            //--Object of type Array 
            List<int?> l = new List<int?>();
            l.Add(1);
            l.Add(10);//1 10
            l.Add(20);//1 10 20
            l.Insert(1, 1000);//1 100 10 20
            l.RemoveAt(2);//1 1000 20
            l.Remove(1000);

            var l2 = new List<int>() { 10,20,30 };
            int founditem = l2.Find(n => n >10);
            int foundindex= l2.FindIndex(n => n == 30);
            if (foundindex>0)
            {
                Console.WriteLine(foundindex);
            }
            //Foeach LOOP is iterating each value of the array
            foreach (int numItem in l2)
            {
                Console.WriteLine(numItem);
            }

            l2.ForEach(a => Console.WriteLine(a));

            List<int> subList = l2.FindAll(n => n > 10);
            foreach (int item in subList)
            {
                Console.WriteLine(item);
            }

        }


        //Get From Users 2 Parameters
        // - width
        // - hight
        // - char tav
        //Print Rectangle on the console 
        public static void DrawRectangle(int height,int width,char tav)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(tav);
                }
            }
        }


        public static void ShowMenu()
        {
            bool isContinue = true;
            while (isContinue)
            {
                isContinue = MainMenu();
            }

        }


        private static bool MainMenu()
        {

            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Operation 1");
            Console.WriteLine("2) Operation 2");
            Console.WriteLine("3) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Operation1();
                    return true;
                case "2":
                    Operation2();
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }
        }

        private static void Operation2()
        {
            Console.WriteLine("Operation 2 Executing....");
            Console.ReadKey();
        }

        private static void Operation1()
        {
            Console.WriteLine("Operation 1 Executing....");
            Console.ReadKey();
        }
    }
}
