using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    internal class DirectorSchool:WorkerSchool
    {

        public List<Teacher> Teachers { get; private set; }
        public List<Clazz> Clazz { get; private set; }


        internal DirectorSchool(int salary,string firstNane, string lastNane, int ageBorn, Sex sex)
             :base (salary,firstNane, lastNane, ageBorn, sex)
        {
            
        }

        public School School { get; private set; }

        public void SetSchool(School school) { School = school; } 
        public void SetClazz(List <Clazz> clazz) { Clazz = clazz; }
        public void SetTeacher(List <Teacher> teach) { Teachers = teach; }



        /*   public bool SetClassTeacher (Clazz clazz, Teacher teacher)
           {clazz }*/


    }
}
