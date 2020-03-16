using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld
{
    public class Person
    {
        public string firstName;
        public string Lastname;

        public void Introduce()
        {
            Console.WriteLine("my name is " + firstName + " " + Lastname);
        }
    }
}
