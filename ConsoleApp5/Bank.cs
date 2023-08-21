namespace ConsoleApp5
{

    public class Bank
    {
        private decimal amount;
        private string bew;
        private double fieldName;
        private int ID;


        public Bank(decimal amount, int id, double fieldName, string bew)
        {
            this.amount = amount;
            ID = id;
            this.fieldName = fieldName;
            this.bew = bew;
        }

        public override string ToString()
        {
            return $"{{id :{ID}, name:{bew}, amount :{amount}, fieldName: {fieldName}}}";
        }
    }
}