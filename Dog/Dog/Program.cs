using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog
{
    class Dog
    {
        public string name;
        public string owner;
        public int age;
        public string year;
        public enum Gender
        {
            Male,
            Female
        }

        public Dog(string name, string owner, int age, Gender Gender)
        {
            this.name = name;
            this.owner = owner;
            this.age = age;
        }
        public void Bark(int count)
        {
            for (int i = 1; i <= count; i++)
            Console.WriteLine("Woof!");
        }
        public void GetTag()
        {
            if (age >= 1)
            {
                year = "year";
            }
            else
            {
                year = "years";
            }
            Console.WriteLine("If lost, call {0}. It's name is {1} and it is {2} {3} old.", owner, name, age, year);
        }







        static void Main()
        {
            Dog puppy = new Dog("Orion", "Shawn", 1, Gender.Male);
            puppy.Bark(8);
            puppy.GetTag();
            Console.ReadLine();
        }






    }
}
