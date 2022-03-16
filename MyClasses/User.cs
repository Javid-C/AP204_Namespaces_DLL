using System;
using System.Collections.Generic;
using System.Text;

namespace MyClasses
{
    public class User:Human
    {
        public string Username;
        public readonly string Password;

        public User(string name, string surname,string pw):base(name,surname)
        {
            //Human human = new Human("Shemsi", "Bayramli");
            //human.Name = "test";
            //human.las
            Surname = surname;
            Password = pw;
        }

        //public void setPw()
        //{
        //    Password = "123Javid";
        //}


    }
}
