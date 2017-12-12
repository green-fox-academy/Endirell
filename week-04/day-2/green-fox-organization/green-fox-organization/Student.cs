using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace green_fox_organization
{
    class Student : Person
    {
        string previousOrganization;
        int skippedDays;

        public Student(string name, int age, string gender, string previousOrganization)
        {
            base.name = name;
            base.age = age;
            base.gender = gender;
            this.previousOrganization = previousOrganization;
            this.skippedDays = 0;
        }

        public Student()
        {
            base.name = "Jane Doe";
            base.age = 30;
            base.gender = "female";
            this.previousOrganization = "The School of Life";
            this.skippedDays = 0;
        }

        public new void Introduce()
        {
            Console.WriteLine("Hi, I'm " + name + ", a " + age + " year old " + gender + " from " + previousOrganization + " who skipped " + skippedDays + " days from the course already.");
        }

        public new void GetGoal()
        {
            Console.WriteLine("My goal is: Be a junior software developer.");
        }

    }
}
