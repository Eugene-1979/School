using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    internal class Student : Person
    {
        public override string ToString()
        {
            string temp= Sex == Sex.Female ? "ка" : "";
            return $"{base.ToString()} студент{temp}";
        }
        public Student(string firstNane, string lastNane, int ageBorn, Sex sex) : base(firstNane, lastNane, ageBorn, sex)
        {
        }
    }
}
