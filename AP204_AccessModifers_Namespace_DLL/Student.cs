using MyClasses;
using System;

namespace AP204_AccessModifers_Namespace_DLL
{
    public class Student : Human
    {
        string _group;
        byte _point;
        byte _age;

        public byte Age
        {
            set
            {
                _age = value;
            }
        }
        public string Firstname
        {
            get
            {
                return Name;
            }

        }

        public string Lastname
        {
            get
            {
                return Surname;
            }
        }
        public string Group
        {
            get
            {
                return _group;
            }
            set
            {
                if (value.Length == 6)
                {
                    _group = value;
                }
                else
                {
                    Console.WriteLine("Group adini duzgun daxil edin");
                }
            }
        }

        public byte Point
        {
            get
            {
                return _point;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _point = value;
                }
                else
                {
                    Console.WriteLine("Duzgun bal daxil edin");
                }
            }
        }

        public Student(string name, string surname, string group, byte point) : base(name, surname)
        {
            Group = group;
            Point = point;
        }

        protected void getInfo()
        {
            Console.WriteLine("Private");
            //Heig
        }
    }
}
