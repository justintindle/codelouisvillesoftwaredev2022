using HelloWorld.Test;
using System;
using System.Collections.Generic;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person justin = new Person
            {
                Name = "Justin Tindle",
                Height = 60
            };

            Person ross = new Person { Name = "Ross", Height = 62 };
            Person jake = new Person { Name = "Jake", Height = 61 };

            IList<Person> persons = new List<Person>();

            persons.Add(justin);
            persons.Add(ross);
            persons.Add(jake);

            foreach(Person people in persons)
            {
                if (people.Height > 61)
                {
                    people.TellYouMyName();
                }
                else if (people.Height == 61)
                {
                    Console.WriteLine($"{people.Name} is just right.");
                }
                else
                {
                    Console.WriteLine($"Poor {people.Name} is too Short.");
                }
            }
        }
    }
}