using System;
namespace dersde_yazdiqlarimiz.Models
{
    public class Developer:Person
    {
        //fields
        
        public int salary;

        //public Student()
        //{
        //    Console.WriteLine("constructor ishledi");
        //}
        public Developer()
        {
            Console.WriteLine("parametrsiz constructor ishledi");
        }
        public Developer(string name) : this()
        {
            this.name = name;
        }
        public Developer(string name, string surname, int age) : this(name)
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
