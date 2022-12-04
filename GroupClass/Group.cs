using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupClass
{
    internal class Group
    {
        public int No;
        public int Limit = 20;
        public Student[] Students;
        
        public Group(int no, int limit, Student[] students)
        {
            No = no;
            Limit = limit;
            Students = students;
        }


        public void AddStudent()
        {
            if (Students.Length<Limit)
            {
                Console.WriteLine("Yeni telebe qrupa elave edildi");
            }
            else
            {
                Console.WriteLine("Qrupun sayi limitde oldugu ucun yeni telebe sisteme elave edilmedi");
            }
        }



        public void GetStudents()
        {   
            foreach (var data in Students)
            {
                data.database();
            }
        }
    }
}
