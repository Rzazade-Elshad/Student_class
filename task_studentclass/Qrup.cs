using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_studentclass
{
    public class Group
    { //2.Group classiniz olur. Propertyleri: Name, Shift,  Student[] students arrayi,
      //AddStudent(Student student) methodu->verilen student obyektini array - e elave edir,
      //FindStudent(string name) methodu->verilen addaki telebenin students arrayinde olub olmadigini yoxlayirsiz.  {
        public string Name { get; set; }
        public string Shift { get; set; }
        public int Telebe_sayi = 0;
        public int Telebe_tutumu { get; set; }
        public Student[] students { get; set; }

        public Group(string name, string shift, int telebe_tutumu)
        {
            Name = name;
            Shift = shift;
            Telebe_tutumu = telebe_tutumu;
            students = new Student[Telebe_tutumu];

        }

        public void AddStudent(Student student)
        {
            if (student.group == null)
            {
                student.group = Name;
                students[Telebe_sayi] = student;
                Console.WriteLine("elave edildi");
            }
            else if (student.group == Name)
            {
                if (checkout(student, students))
                {
                    Console.WriteLine("telebe artiq qrupda movcutdur");
                }
                else
                {
                    students[Telebe_sayi] = student;
                    Console.WriteLine("elave edildi");

                }

            }
            else0
            { 
                    student.group = Name;
                    students[Telebe_sayi] = student;
                    Console.WriteLine("elave edildi");               
            }
            Telebe_sayi++;
        }

        public Student FindStudent(string name)
        {
            foreach (var student in students)
            {
                if (student.Name.ToLower() == name.ToLower())
                {
                    return student;
                }
            }
            return null;
        }
        public bool checkout(Student student, Student[] students)
        {
            bool flaq = false;
            foreach (var i in students)
            {
                if (i == student)
                {
                    flaq = true;
                    break;
                }
            }
            return flaq;
        }
    }
}
