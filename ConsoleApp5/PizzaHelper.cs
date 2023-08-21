namespace ConsoleApp5
{

    public static class PizzaHelper
    {
        public static Pizza addDoght(this Pizza value, string type)
        {

            value.Content += $"{type} is 4.00$";
            value.Price += 4m;
            return value;

        }
    }
}