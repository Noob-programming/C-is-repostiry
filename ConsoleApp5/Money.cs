namespace ConsoleApp5
{

    public class Money
    {
        public Money(decimal amount) { Amount = amount; }

        public static Money operator +(Money a, Money b)
        {
            return new Money(a.Amount + b.Amount);
        }

        public decimal Amount { get; set; }
    }
}