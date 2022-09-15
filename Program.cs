using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_class_1
{
    class Student
    {
        private int _id;
        public int Id
        {
            get => _id;
            set => _id = value;
        }
        public String name { get; set; }
        public String adress { get; set; }
        public String email { get; set; }

    }
    class Program : Student
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Id = 10;
            Console.WriteLine(student.Id);
        }
    }
}
