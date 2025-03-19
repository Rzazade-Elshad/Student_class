using System.Collections.Generic;
using System.Xml.Linq;
using System.Reflection;
using System;

namespace task_studentclass
{
    internal class Program
    {
        static void Main(string[] args)
        {  //3.Student obyekti yaradin. Group obyekti yaradin.Daha sonra studenti groupdaki students arrayine elave edin. -bunu consoleda edin. 
           //5.Var olmayan Group-a student elave etmek olmasin. Yeni bir studenti qrupa elave etmek istememishden once o qrupun olub olmadigini yoxlayirsiz.
            Group group1 = new Group("BB208", "2_ci_novbe",5);

            Student student1 = new Student("Elşad", "Rzazadə", "Male", 20, "0107244221", 3, "BB208");
            group1.AddStudent(student1);

            student1.Absent(); 
            student1.Absent();
            student1.Absent();
            student1.Absent(); 

            Student f = group1.FindStudent("Elşad");
            if (f != null)
            {
                Console.WriteLine($"{f.Name} qrupda tapıldı.");
            }
            else
            {
                Console.WriteLine("Tələbə qrupda yoxdur.");
            }
        }
    }
}
