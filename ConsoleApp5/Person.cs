namespace ConsoleApp5
{
    public class Person
    {
        public Person(string name, int age)
        {
            _name = name;
            _age = age;
        }

        private int _age { get; }
        private string _name { get; }

        public override string ToString()
        {
            return $@"_name is {_name}, Age is {_age}";
        }
    }
}