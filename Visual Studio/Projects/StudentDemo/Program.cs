using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace safeprojectname
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Darragh",32);
            //Adrian's step2
            Person[] people = new Person[2];

            Student statler = new Student();
            statler.setName("Statler");
            statler.setAge(20);

            Staff waldorf = new Staff();
            waldorf.setName("Waldorf");
            waldorf.setAge(40);

            people[0] = statler;
            people[1] = waldorf;
            //end part 2 of adrian's

            //for loop part
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(people[i].toString());

            }

            
            Console.WriteLine(p.toString());
            Console.ReadLine();

            //step2
            /*
            String[] people = { "eoin", "fintan", "darragh" };
            for (int i = 0; i < 3; i++)
            {
                Person p = new Person(people[i],age);
                //  p.setAge(i + 10 * 2);
                //p.setName(names[i]);
                // p.setName(Console.ReadLine());
                Console.WriteLine(p.toString());
            }*/
            

            


            // Exercises:
            // 1. Add back in our constructor which takes name and age
            // 2. Create an array of Person called people and then create 
            //    some staff and students to add to that array
            //    Write a for loop to iterate through the array and call the toString method
            // 3. Create a unit test for our toString class
            // 4. Add a list of modules to a student  (dynamic array)
            // 5. Create a method that lets a course be added to a student
            // 6. For bonus points create a method that can remove a module from a student

        }
    }
}
