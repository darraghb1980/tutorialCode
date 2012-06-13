using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace safeprojectname
{
    public class Person
    {
        private int age;
        private string name;
       // private static Person me = null;

        //empty constructor
        public Person()
        {
        }
       public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

       
        public void setAge(int age)
        {
            this.age = age;
        }

        public int getAge()
        {
            return this.age;
        }

        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return this.name;
        }

        public String toString()
        {
            return "The age of " + name + " is " + age;
        }

       /* public String makeUpName()
        {
            String rtr = "Name is  " + name;
            return rtr;
        }*/


    }
}
