namespace ConsoleApp5
{
    public class Employee
    {
        public override bool Equals(object obj)
        {
            if (obj is Employee emp)
                return (Id == emp.Id) && (Salary == emp.Salary) && (Departemt == emp.Departemt);
            return false;
        }

        public override int GetHashCode()
        {
            var hash = 27;
            hash = (hash * 9) + Id.GetHashCode();
            hash = (hash * 9) + Salary.GetHashCode();
            hash = (hash * 9) + Departemt.GetHashCode();
            return hash;
        }

        public string Departemt { get; set; }

        public int Id { get; set; }

        public decimal Salary { get; set; }
    }
}