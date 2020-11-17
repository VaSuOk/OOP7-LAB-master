using System;
using ClassLibrary;
namespace OOP7_LAB
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Teacher teacher = new Teacher();
            Library_user library_User = new Library_user();
            Applicant applicant = new Applicant();
            Student student = new Student();
            Human human = new Human();

            Console.WriteLine("          Людина");
            human.Init_Human();
            human.Show_Info();

            Console.WriteLine("          Студент");
            student.Init_Student();
            student.Show_Info();

            Console.WriteLine("          Абітуріент");
            applicant.Init_Aplicant();
            applicant.Show_Info();

            Console.WriteLine("          Вчитель");
            teacher.Init_Teacher();
            teacher.Show_Info();

            Console.WriteLine("          Користувач бібліотеки");
            library_User.Init_Library_user();
            library_User.Show_Info();

        }
    }
}
