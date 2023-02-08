using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.CommonTypes
{
    public  class EnumsDemos
    {

        public static void Run()
        {
            Color c1 = Color.Red;
            var c2 = Color.Blue;

            if (c1 == Color.Red)
            {
                Console.WriteLine("Its Red");
            }
            else 
            {
            
            }
            if (c1 != c2)
            {
                Console.WriteLine("Not Equal");
            }

            //Convert To number
            int x = (int)c1;
            int y =10;
            Color c3 = (Color)y;


            object o1 = Color.Green;
            if ((Color)o1 == Color.Green)
            {

            }



            object myColor;
            //"Blue" ---> Color.Blue
            string colorText = Console.ReadLine();
            bool isConvertedOk = Enum.TryParse(
                typeof(Color),// Type To Do the Convert
                colorText, //  String Value
                out myColor //Out Object To Assign
                );

            if  (isConvertedOk)
            {
                //Convert Object to Enum 
                Color c = (Color)myColor;
                int val = (int)c;
                Console.WriteLine(c + "-->"+val);
            }


            //1) Create Generic List of type Employee add items
            
            //2) Create method that get employee as parameter 
            //And for each type print Hello
            //Hello Developer
            //Hello QA

            //1)
            List<Employee> employeesTypes = new List<Employee>();
            employeesTypes.Add(Employee.QA);
            employeesTypes.Add(Employee.Developer);

            //2)
            TestMethod(employeesTypes[1]);

            //3 Get Enums As Array of Strings
            string[] names =  Enum.GetNames(typeof(Employee));
            foreach (string name in names)
            {
                Console.Write(name + "|");
            }


        }

        private static void TestMethod(Employee emp)
        {
            switch (emp)
            {
                case Employee.Developer:
                {
                    Console.WriteLine("Hello Developer ");
                    break;
                }
                case Employee.QA:
                    {
                        Console.WriteLine("Hello QA ");
                        break;
                    }
                case Employee.Manager:
                    {
                        Console.WriteLine("Hello Manager ");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Hello General ");
                        break;
                    }

            }
        }
    }


    public enum Color
    {
        Red   = 10,
        Blue  = 20,
        Green = 30
    }



    public enum Employee
    {
        General = 0,
        Operator = 1,
        Developer = 2,
        QA = 3,
        Manager = 4
    }

}
