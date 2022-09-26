using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Test
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Height { get; set; }

        public void TellYouMyName()
        {
            Console.WriteLine("Hi my name is " + Name);

            TellYouMyName("Bob");
        }

        private void TellYouMyName(string name)
        {
            Console.WriteLine($"Hi, name passed in {name}, my name is {Name}");
        }
    }
}
