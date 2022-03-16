using MyClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace AP204_AccessModifers_Namespace_DLL
{
    class Doctor:Human
    {
        public string Area;

        public Doctor(string name, string surname) : base(name, surname)
        {
            //Gender
        }
        public void createHuman()
        {
            //Human human = new Human("Fazil", "Quliyev");
            //human.gender

        }
    }
}
