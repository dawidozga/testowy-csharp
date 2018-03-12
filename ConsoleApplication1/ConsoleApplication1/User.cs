using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class User
    {
        private string name;
        private string lastname;
        private int age;

        public User()
        {

        }

        public User(string name, string lastname, int age)
        {
            this.name = name;
            this.lastname = lastname;
            this.age = age;
        }

        public string Name
        {
            get { return name;}
            set {name = value;}
        }

        public string Surname
        {
            get { return lastname; }
            set {lastname = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

    }
}
