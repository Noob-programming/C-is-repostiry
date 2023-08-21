namespace ConsoleApp5
{
    public class Employees
    {

        public int ID { get; set; }
        public string name { get; set; }
        public int? Reportto { get; set; }

        public override string ToString()
        {
            return $"[{ID}] : '{name}'";
        }
        /*
               var emp = new List<Employees>
               {
               new Employees{ID = 200,name = "rone",Reportto = null},
               new Employees{ID = 100,name = "rone",Reportto = 200},
               new Employees{ID = 105,name = "rone",Reportto = 100},
               new Employees{ID = 112,name = "rone",Reportto = 100},
               new Employees{ID = 106,name = "rone",Reportto = 105},
               };
               
               var menger = emp.ToLookup(x => x.Reportto)
               .ToDictionary(x => x.Key ?? -1, x => x.ToList());
               foreach (var item in menger)
               {
               if (item.Key == -1)
               {
               continue;
               }
               
               var man = emp.FirstOrDefault(x => x.ID == item.Key);
               Console.WriteLine($"'{man}'");
               foreach (var emps in item.Value)
               {
               Console.WriteLine("\t\t\"" + emps + "\t\t\"");
               }
               }
    
    
             */
    }
}