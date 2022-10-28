using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    internal abstract class WorkerSchool:Person
    {

       /* работник школі-наследуется от персон*/
        protected WorkerSchool(int salary, string firstNane, string lastNane, int ageBorn, Sex sex)
            :base (firstNane, lastNane, ageBorn, sex)
        {
            Salary = salary;
        }
        public override string ToString()
        {
            return $"{base.ToString()}  Salary-{Salary}";
        }
        public int Salary { get; set; }


    }
}
