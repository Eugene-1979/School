using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    internal class School
    {
        private static int NumberScholl=1;

        static public int MAXSTUDENTINCLASS = 30;
        public int Number { get; init; } = NumberScholl++;
         public List<Teacher> Teachers { get;init ; }=new List<Teacher>();
        public List<Clazz> Clazz { get; init; }=new List<Clazz>();
        public DirectorSchool Director { get; set; }

       

        public School(List<Teacher> teachers, DirectorSchool director,int number)
        {
         
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
           
            Number = number;
            director.SetClazz(Clazz);
            director.SetTeacher(Teachers);
        }

        public School(int number)
        {
            Clazz = new List<Clazz>();
            Number = number;
           
        }

        bool AddTeacher(Teacher teacher) {
             Teachers.Add(teacher);
            return true;
        }


        /*Распределяем студентов по классам , назначая классного руководителя и старосту*/

        public void addStudent(Student student) {
            if ((Clazz.Count==0)||
                (Clazz?.
                Last()?.
                Students?.
                Count 
                > MAXSTUDENTINCLASS)) {
                Clazz.Add(new Clazz(this));
                Clazz.Last().SetHeadman(this,student );
            }
            
            Clazz.Last().Students.Add(student);
        
        }

        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
            sb.Append(Director);
            foreach (var item in Clazz)
            {
                sb.Append(item);
                sb.Append(Environment.NewLine);
                sb.Append(Environment.NewLine);
            }

            return sb.ToString();


/*            return $@"{Director}

{Clazz[0]}
";*/



        }
    }
}
