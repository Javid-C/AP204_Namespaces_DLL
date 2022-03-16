using System;
using System.Collections.Generic;
using System.Text;

namespace MyClasses.Model
{
    public class Teacher:Human
    {
        public string Profession;


        public Teacher(string name,string surname):base(name,surname)
        {
            Height = 180.5d;
        }
        public void createHuman()
        {
            Human human = new Human("Ilkin","Yusubov");
            human.Gender = "Male";
            Height = 100d;
        }
    }
}
