using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    internal class Teacher:WorkerSchool
    {

       /* Учитель-наследуется от работник школі*/
        public Teacher( Lessons teacherLesson,
            int salary, string firstNane, string lastNane, int ageBorn, Sex sex
            ) :base(salary,firstNane,lastNane,ageBorn,sex)
        {
           
            TeacherLesson = teacherLesson;
        }




        public bool IsClassTeacher { get; private set; }
        public Lessons TeacherLesson { get; private set; }

        public override string ToString()
        {
            return $"{ base.ToString()}   {TeacherLesson} ";
        }


    }
}
