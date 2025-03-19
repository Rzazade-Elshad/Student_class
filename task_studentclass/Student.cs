using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_studentclass
{
    public class Student
    {// 1.Student classiniz olur. Propertyleri: Name, Surname, Gender, Age, PhoneNumber, Limit, Group.Methodu Absent(). 
     //4.Student classindaki Absent() methodunu ishledende Limit bir vahid azalir ve ekrana Telebe bu gun derse gelmeyib verirsiz.
     // Limit 0dan ashagi dushmemelidir(yeni menfi olmamalidir).Limit 0 olanda “Kesildiniz” verin ekrana. 
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public int Limit { get; set; }
        public string group { get; set; }

        public Student(string name, string surname, string gender, int age, string phoneNumber, int limit)
        {
            Name = name;
            Surname = surname;
            Gender = gender;
            Age = age;
            PhoneNumber = phoneNumber;
            Limit = limit;
        }
        public Student(string name, string surname, string gender, int age, string phoneNumber, int limit, string group)
        {
            Name = name;
            Surname = surname;
            Gender = gender;
            Age = age;
            PhoneNumber = phoneNumber;
            Limit = limit;
            this.group = group;
        }

        public void Absent()
        {
            if (Limit > 0)
            {
                Limit--;
                Console.WriteLine($"{Name} bu gün dərsə gəlməyib. Qalan limit: {Limit}");
            }
            else
            {
                Console.WriteLine($"{Name} artıq dərsdən kəsilib.");
            }
        }
    }
}
