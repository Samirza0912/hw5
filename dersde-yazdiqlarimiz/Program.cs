using dersde_yazdiqlarimiz.Models;
using System;

namespace dersde_yazdiqlarimiz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            #region ClassIntro
            string name1 = "Ben";
            string surname1 = "White";
            int age1 = 23;

            string name2 = "Kieran";
            string surname2 = "Tierney";
            int age2 = 24;

            var obj1 = new
            {
                name1 = "Ben",
                surname1 = "White",
                age1 = 23
            };
            var obj2 = new
            {
                name2 = "Kieran",
                surname2 = "Tierney",
                age2 = 23
            };

            #endregion
            #region class
            //int num=5;
            //Console.WriteLine(num);

            Student stu1 = new Student();
            stu1.name = "Bukayo";
            stu1.surname = "Saka";
            stu1.age = 20;
            Console.WriteLine(stu1.name);
            stu1.Info();

            Student stu2 = new Student();
            stu2.name = "Emil";
            stu2.surname = "Smith-Rowe";
            stu2.age = 22;
            stu2.Info();

            int[] arr = { 1, 2, 3, 4 };
            Student[] students = { };
            students[0] = stu1;
            foreach (var item in students)
            {
                item.Info();
            }
            #endregion
            #region constructor
            //Student stu3 = new Student("bukayo","saka",20);
            //stu3.name = "bukayo";
            //stu3.surname = "saka";
            //stu3.age = 20;
            //Console.WriteLine(stu3.name);
            //Student stu4 = new Student("Emil", "Smith-Rowe",22);
            //stu4.Info();

            Student stu5 = new Student("Mamed","Mamedov",20);

            #endregion
            #region inheritance
            Developer dev1 = new Developer();
            dev1.salary = 50;
            dev1.name = "Emil";
            #endregion
        }
    }


}
