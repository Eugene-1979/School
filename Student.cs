using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    internal class Student : Person
    {
        public Student(string firstNane, string lastNane, int ageBorn, Sex sex) : base(firstNane, lastNane, ageBorn, sex)
        {
        }
    }
}
