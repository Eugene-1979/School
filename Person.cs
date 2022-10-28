using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{

    

    internal abstract class Person
        
    {
        protected Person(string firstNane, string lastNane, int ageBorn, Sex sex)
        {
            FirstNane = firstNane;
            LastNane = lastNane;
            AgeBorn = ageBorn;
            Sex = sex;
        }

        public override string? ToString()
        {
            return $"{FirstNane,10}  {LastNane,10}  {AgeBorn,10}  {Sex,10}";
        }

        public string FirstNane { get; init; }
        public string LastNane { get; init; }
        public int AgeBorn { get; init; }
        public  Sex Sex { get; init; }
    }


}
