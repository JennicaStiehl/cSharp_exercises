using System;
namespace HelloWorld
{
    public class Person
    {
        public string firstName;
        public string lastName;
        public void Introduce()
        {
            Console.WriteLine("Hi, my name is {0}", firstName);
        }
    }
}
