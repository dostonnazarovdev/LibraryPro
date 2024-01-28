using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryPro
{
    public class Student
    {
        private int v;

        public Student(int id, string name, string surname, string phone, int level)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Phone = phone;
            Level = level;
        }

        //tring name, string surname, string phone, int level
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public int Level { get; set; }


    }
}
