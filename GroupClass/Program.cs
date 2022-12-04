using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;

namespace GroupClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student studentNo1 = new Student("Huseyn", "Ahadzada", "A");
            Student studentNo2 = new Student("Ayxan", "Mustafazada", "A");
            Student studentNo3 = new Student("Fikrat", "Amirov", "A");
            Student studentNo4 = new Student("Sahin", "Ruhullayev", "A");
            Student studentNo5 = new Student("Mahir", "Salahov", "A");
            Student studentNo6 = new Student("Sabir", "Imanov", "A");

            Student[] Students = { studentNo1, studentNo2, studentNo3, studentNo4, studentNo5, studentNo6 };
           
            Group Total = new Group(1, 15, Students);
        
            
            Total.AddStudent();
            Total.GetStudents();
        
            
          
            Console.Write("Qrupdaki movcud telebelerin sayi: ");
            Console.WriteLine(Students.Length);
        }
    }
}