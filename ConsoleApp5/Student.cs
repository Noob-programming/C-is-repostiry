using System;

namespace ConsoleApp5
{
    public class Student : IObserver
    {
        private readonly string _name;

        public Student(string name)
        {
            _name = name;
        }

        public void Updata(string message)
        {
            Console.WriteLine($"{_name} has notif : {message} ");
        }
    }
}