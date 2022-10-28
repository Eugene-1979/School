using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    internal class Clazz
    {
        static int count = 0;
        int NumberClass { get; init; }
        /* ограничил права доступа.Только директор может формировать классы*/
        public School school { get; init; }



        public Clazz(int numberClass, School school, Student? headman, List<Student>? students, Teacher? classroomTeacher)
        {
            NumberClass = numberClass;
            this.school = school;
            Headman = headman;
            Students = students;
            ClassroomTeacher = classroomTeacher;
        }

        public Student? Headman { get; private set; }


        public List  <Student> ? Students { get; private set; }




        


        public bool addStudent(Person pers, Student student) {



            if (pers is DirectorSchool dir $$dir.School==)
            {
                
                Students = new List<Student>(student);
                return true;
            }
            else return false;
        }




        public bool SetClassroomTeacher(Person pers, params Student [] stud)
        {
            if (pers is DirectorSchool)
            {

               Students=new List<Student> (stud);
                return true;
            }
            else return false;


        }



        /* ограничил права доступа.Только учитель может назначать старосту*/
       


        public bool SetClassroomTeacher(Person pers,Student headman)
        {
            if (pers is Teacher)
            {

                Headman = headman;
                return true;
            }
            else return false;


        }

        /* ограничил права доступа.Только директор может назначать классного руководителя*/
        public Teacher ? ClassroomTeacher { get; private set; }

        public bool SetClassroomTeacher (Person pers,Teacher teacher) {
            if (pers is DirectorSchool)
            {

                ClassroomTeacher = teacher;
                return true;
            }
            else return false;


        }






    }
}
