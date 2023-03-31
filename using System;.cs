using System;

namespace Persona7Class
{
    class Persona7
    {
        public string fullName;
        public int age;

        public Persona7()
        {
            fullName = "nu kak tam s dengami";
            age = 0;
        }

        public Persona7(string fullName, int age)
        {
            this.fullName = fullName;
            this.age = age;
        }

        public void move()
        {
            Console.WriteLine("man " + fullName + " goes");
        }

        public void talk()
        {
            Console.WriteLine("man " + fullName + " says");
        }
    }