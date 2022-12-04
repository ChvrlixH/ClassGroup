using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GroupClass
{
    internal class Student
    {
        public string Name;
        public string Surname;
        public string GpClass;
        public Student (string name, string surname, string gpClass)
        {
            Name = name;
            Surname = surname;
            GpClass = gpClass;
        }
        public void database()
        {
            string Fullname = Name + "  " + Surname;
            Console.WriteLine($"Shagird: {Fullname}");
        }
    }
}
