using System;

namespace ConsoleApp5
{

    public class Country
    {

        /*var Iraq = new Country { iso = "IRQ", name = "Iraq" };
                    var egypt = new Country { iso = "EGY", name = "Egypt" };
                    var newline = new Country { iso = "IRQ", name = "newlane" };
    
                    Country[] countries = { Iraq, egypt, newline };
    
    
                    //constryctors
                    List<Country> list = new List<Country>();
    
                    //
    
                    // method
                    list.Add(new Country { iso = "sadjh", name = "fdhh" });
                    list.Add(new Country { iso = "sadjh", name = "fdhh" });
                    list.AddRange(countries);
                    list.Insert(1, new Country { name = "df", iso = "sdfs" });
    
                    Print(list);
    
                    list.RemoveAll(x => x.name.EndsWith("hh"));
                    Print(list);
                    */
        public string iso { get; set; }
        public string name { get; set; }

        public override string ToString()
        {
            return $"{name} ({iso})";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 13;
                hash = hash * 93 + name.GetHashCode();
                hash = hash * 93 + iso.GetHashCode();
                return hash;
            }
        }

        public override bool Equals(object obj)
        {
            var country = obj as Country;
            if (country is null)
                return false;
            return name.Equals(country.name, StringComparison.OrdinalIgnoreCase)
                   && iso.Equals(country.iso, StringComparison.OrdinalIgnoreCase);
        }
    }
}