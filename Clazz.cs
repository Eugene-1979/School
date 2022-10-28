using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    internal class Clazz
    {
        static private int COUNT = 1;
        int NumberClass { get; init; } = COUNT++;
      
        public School school { get; init; }
        public Student? Headman { get; private set; }
        public List<Student>? Students { get; private set; } = new List<Student>();

        public Teacher? ClassroomTeacher { get; private set; }





        public Clazz( School school )        {
           
            this.school = school;
         
            /*По очереди создаются классніе руководители*/
            ClassroomTeacher = school.Teachers[COUNT % school.Teachers.Count];
        }

        


        




        


      /*  public bool addStudent(Person pers, Student student) {



            if (pers is DirectorSchool dir $$dir.School==)
            {
                
                Students = new List<Student>(student);
                return true;
            }
            else return false;
        }*/




        public bool SetClassroomTeacher(Person pers, params Student [] stud)
        {
            if (pers is DirectorSchool)
            {

               Students=new List<Student> (stud);
                return true;
            }
            else return false;


        }


        /* ограничил права доступа.Только школа назначать старосту 
         * ,если этьот класс принадлежит этой школе*/
       
        public bool SetHeadman(School sch,Student headman)
        {
            if (sch ==school)
            {

                Headman = headman;
                return true;
            }
            else return false;


        }

        /* ограничил права доступа.Только директор может назначать классного руководителя*/
        

        public bool SetClassroomTeacher (Person pers,Teacher teacher) {
            if (pers is DirectorSchool)
            {

                ClassroomTeacher = teacher;
                return true;
            }
            else return false;


        }



        public override string ToString()
        {
            return $"Класс-{NumberClass} {Environment.NewLine}{Headman}---староста{Environment.NewLine}{ClassroomTeacher}клас учитель{Environment.NewLine}" +
                $"{string.Join('\n', Students)}"; 
        }


    }
}
