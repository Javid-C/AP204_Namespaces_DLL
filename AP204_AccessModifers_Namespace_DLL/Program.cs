using MyClasses;
using MyClasses.Model;
using System;
using System.Text;

namespace AP204_AccessModifers_Namespace_DLL
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Islam", "Xalitov", "AP-204", 199);
            student.Age = 20;

            //Console.WriteLine(student.Age);

            Console.WriteLine(student.Lastname);

            //student.Firstname = "Malik";

            StringBuilder stringBuilder = new StringBuilder();

            //User user = new User();
            //user.Username = "okay";
            //Console.WriteLine(user.Username);

            Teacher teacher = new Teacher();

            //teacher.

            Human human = new Human("Fazil","Quliyev");
            //human.gen

        }
    }
}
