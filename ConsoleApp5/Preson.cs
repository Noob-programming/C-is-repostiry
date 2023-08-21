namespace ConsoleApp5
{

    public class Preson
    {
        string fname;
        string lname;

        public Preson(string fname, string lname)
        {
            this.fname = fname;
            this.lname = lname;
        }

        public override string ToString() => $"{fname} {lname}";
    }
}