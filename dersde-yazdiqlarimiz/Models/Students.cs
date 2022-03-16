using System;
namespace dersde_yazdiqlarimiz.Models
{
    class Student:Person
    {
        //fields
        
        public string profession;

        //public Student()
        //{
        //    Console.WriteLine("constructor ishledi");
        //}
        public Student()
        {
            Console.WriteLine("parametrsiz constructor ishledi");
        }
        public Student(string name):this()
        {
            this.name = name;
        }
        public Student(string name, string surname, int age):this(name)
        {
            //this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public void Info()
        {
            Console.WriteLine($"{this.name}");
        }
    }
}