using MyClasses.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyClasses
{
    public class Human
    {
        public string Name;
        protected string Surname;
        protected internal string Gender;
        private protected double Height;

        public Human(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public void createTeacher()
        {
            //Teacher teacher = new Teacher();
        }
    }
}
