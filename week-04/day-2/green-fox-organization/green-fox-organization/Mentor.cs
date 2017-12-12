using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace green_fox_organization
{
    class Mentor : Person
    {
        string level;


        public Mentor(string name, int age, string gender, string level)
        {
            base.name = name;
            base.age = age;
            base.gender = gender;
            this.level = level;
            
        }

        public Mentor()
        {
            base.name = "Jane Doe";
            base.age = 30;
            base.gender = "female";
            this.level = "intermediate";
        }

        public new void Introduce()
        {
            Console.WriteLine("Hi, I'm " + name + ", a " + age + " year old " + gender + " " + level + " mentor.");
        }

        public new void GetGoal()
        {
            Console.WriteLine("My goal is: Educate brilliant junior software developers.");
        }




    }
}
