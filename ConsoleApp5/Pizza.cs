namespace ConsoleApp5
{
    public class Pizza
    {


        public string Content { get; set; }

        public decimal Price { get; set; }
        public override string ToString()
        {
            return $"{Content} \n price is {Price}";
        }
    }
}