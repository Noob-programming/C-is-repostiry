using System;

namespace ConsoleApp5
{

    public class Temp : IComparable
    {
        public Temp(int value) { Value = value; }

        public int CompareTo(object obj)
        {
            if (obj is null)
                return 1;

            var temp = obj as Temp;

            if (temp is null)
                throw new ArgumentException("not temp");

            return Value.CompareTo(temp.Value);
        }

        public int Value { get; set; }
    }
}