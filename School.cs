using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    internal class School
    {
        public int Number { get; init; }
        public List<Teacher> Teachers { get; init; }
        public List<Clazz> Clazz { get; init; }
        public DirectorSchool Director { get; set; }

       

        public School(List<Teacher> teachers, DirectorSchool director,int number)
        {
            Clazz = new List<Clazz>();
            Number = number;
            Teachers = teachers;
            Director = director;
            director.SetSchool(this);
            director.SetClazz(Clazz);
            director.SetTeacher(Teachers);
        }

        public School(DirectorSchool director, int number)
        {
            Clazz = new List<Clazz>();
            Number = number;
            Director = director;
            director.SetSchool(this);
            Teachers = new List<Teacher>();
            Number = number;
            director.SetClazz(Clazz);
            director.SetTeacher(Teachers);
        }

        public School(int number)
        {
            Clazz = new List<Clazz>();
            Number = number;
            Teachers = new List<Teacher>();
        }

        bool AddTeacher(Teacher teacher) {
             Teachers.Add(teacher);
            return true;
        }

        public void addStudent(Student student) {
       
        
        }


    }
}
