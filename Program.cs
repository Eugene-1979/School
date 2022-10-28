namespace School
{
    internal class Program
    {
        static void Main(string[] args)
        {
         /*   Создали директора*/
          DirectorSchool director=new DirectorSchool(50000,"Bob","Director",1969,Sex.Male);

            

            /*наняли на work.ua 25 учителей*/
                List <Teacher> teacher= new List<Teacher>();
            for (int i = 0; i <25; i++)
            {
                teacher.Add(new Teacher((Lessons)i, 10000 + (i * 500), $"{i}Teacher", "Olya", 1970 + i, (Sex)(i % 2)));
            };
          /* создали школу*/
            School school = new School(teacher, director,98);

            
           /* создали студентов и добавляем в школу*/
           /*в школе формируются классы по мере заполнения (классы 30 чел)
                и назначается классный руководитель*/

            for (int i = 0; i < 5000; i++)
            {
                school.addStudent(new Student($"{1}Student", "Dima", 2000 + (i % 10), (Sex)(i % 2)));
            }






            

        }
    }

    enum Sex {
        Male,
        Female }

   enum Lessons{
        Singing,
Maths,
Physics,
Chemistry,
PhysicalCulture,
EducationalHour,
Drawing,
Story,
Astronomy,
Literature,
Language,
Botany

    }


    enum Week {      
Monday,
Tuesday,
Wednesday,
Thursday,
Friday,
Saturday,
 Sunday
    }


}