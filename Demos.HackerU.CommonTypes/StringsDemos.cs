namespace Demos.HackerU.CommonTypes
{
    public class StringsDemos
    {

        /// <summary>
        /// 
        /// </summary>
        public static void Run()
        {
            TestString();
            Lab1();
            Lab2("abc", "def");

            string res = Lab3("ABC", "DEF");
            Console.WriteLine(res);

            bool isLoggedIn = Lab4_Login("user123", "Pa$$w0rd");
            Console.WriteLine($"is Logged In : {isLoggedIn}");
           
            isLoggedIn = Lab5_Login("user", "12345");
            Console.WriteLine($"is Logged In : {isLoggedIn}");

            bool isEqual =   CheckLowerUpperEquals("abC", "ABc");
            Console.WriteLine("abC == ABc -->" + isEqual);
        }


        /// <summary>
        /// Work With Strings
        /// </summary>
        public static void TestString()
        {
            //--Combine 2 strings
            string s1 = "abc1$#D";
            s1 += "XXXX";
            Console.WriteLine(s1);

            string s2 = "11111";
            string s3 = "22222";
            string s4 = s2 + s3;
            Console.WriteLine(s4);

            //--ToLower ToUpper Method
            string s5 = "aBcD";
            string s6 = s5.ToLower();
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s6.ToUpper());

            //--string.IsNullOrEmpty
            bool isEmpty = string.IsNullOrEmpty(s6);
            if (!isEmpty)
            {
                Console.WriteLine("s6 is Not Empty: " + s6);
            }

            string s7 = "";
            if (string.IsNullOrEmpty(s7))
            {
                Console.WriteLine("s7 is  Empty");
            }
            //--Format String Using $
            string s8 = "123";
            string s9 = "456";
            string txt = $"s8 is {s8} and s9 is {s9}";
            //string txt = "s8 is" + s8 + "and" + s9 + "s9";


        }

        /// <summary>
        /// Lab1: Combine 2 strings 
        /// Print the result string
        /// with ToLower() and ToUpper
        /// </summary>
        public static void Lab1()
        {
            string s1 = "abc";
            string s2 = "ABC";
            string s3 = s1 + s2;
            Console.WriteLine(s3);
            Console.WriteLine("Upper():" + s3.ToUpper());
            Console.WriteLine("Lower():" + s3.ToLower());
        }

        /// <summary>
        /// Lab 2
        /// Use Parameters 
        /// </summary>
        public static void Lab2(string txt1, string txt2)
        {
            string combine = txt1 + txt2;
            Console.WriteLine(combine.ToUpper());
        }

        /// <summary>
        ///  Lab3:
        ///  get 2 string parameters
        ///  and return string 
        /// </summary>
        public static string Lab3(string txt1, string txt2)
        {
            string combine = txt1 + txt2;
            return combine.ToLower();
        }

        /// <summary>
        /// check if user is empty or pass is empty (print msg) 
        /// if user="user123" And pass="Pa$$w0rd" return true
        /// else return false
        /// </summary>
        /// <param name="user">user</param>
        /// <param name="pass">password</param>
        /// <returns>ok if user & password correct</returns>
        public static bool Lab4_Login(string user, string pass)
        {
            bool isValid = false;
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                Console.WriteLine("Empty Value");
            }

            else if (user == "user123" && pass == "Pa$$w0rd")
            {
                Console.WriteLine("login OK...");
                isValid = true;
            }
            else
            {
                Console.WriteLine("Not Valid Credentials");
            }
            return isValid;
        }

        /// <summary>
        /// Get User Password From User
        /// </summary>
        /// <param name="userOk">The Correct User</param>
        /// <param name="passOk">The Correct Pass</param>
        /// <returns></returns>
        public static bool Lab5_Login(string userOk, string passOk)
        {
            bool isValid = false;
            Console.Write("Enter UserName:");
            string userInput = Console.ReadLine();

            Console.Write("Enter Password:");
            string passInput = Console.ReadLine();

            if (userInput == userOk && passInput == passOk)
            {
                isValid = true;
            }
            return isValid;
        }

        /// <summary>
        /// HW1
        /// check if two strings are 
        /// equals ignoring casesensetive
        /// </summary>
        /// <example>
        /// AaB == aAb
        /// </example>
        /// <param name="val1">string 1</param>
        /// <param name="val2">string 2</param>
        /// <returns>is equal or not</returns>
        public static bool CheckLowerUpperEquals(string val1, string val2)
        {
            bool isValid = false;

            if ((val1 == null) && (val2 == null))
            {
                isValid = true;
            }
            //Logic

            if ((val1 != null && val2 != null) &&
                 (val1.ToUpper() == val2.ToUpper()))
            {
                isValid = true;
            }
            return isValid;
        }


    }
}