using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.Wpf
{
    public class Student
    {
        //Property
        public string Name { get; set; }
        public string Id { get;  set; }
        public int Grade { get; set; }

        public string ShowStudent()
        {
            string displayInfo = $"{Id}|{Name}-{Grade}";
            return displayInfo;
        }
        public  bool IsFailed()
        {
            return (Grade <= 55);
        }






    }
}
