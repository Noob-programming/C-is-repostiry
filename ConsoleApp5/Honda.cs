using System;

namespace ConsoleApp5
{

    public class Honda : Vehicle, ILoader, IDrive
    {

        public Honda(string brand, string model, int year) : base(brand, model, year)
        {

        }

        public void Load()
        {
            Console.WriteLine("loading");
        }

        public void Unload()
        {
            Console.WriteLine("unloading");
        }

        public void Move()
        {
            Console.WriteLine("Move");
        }

        public void Stop()
        {
            Console.WriteLine("Stop");
        }
    }
}