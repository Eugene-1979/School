namespace School
{
    internal class Program
    {
        static void Main(string[] args)
        {
         /*   Создали директора*/
          DirectorSchool director=new DirectorSchool(50000,"Bob","Director",1969,Sex.Male);

            /*задали макс число студентов в классе*/
            School.MAXSTUDENTINCLASS = 25;

            /*наняли на work.ua 25 учителей*/
                List <Teacher> teacher= new List<Teacher>();
            for (int i = 0; i <25; i++)
            {
                teacher.Add(new Teacher((Lessons)i, 10000 + (i * 500), $"Teacher{i}", "Olya", 1970 + i, (Sex)(i % 2)));
            };
          /* создали школу*/
            School school = new School(teacher, director,98);


            /* создали студентов и добавляем в школу*/
            /*в школе формируются классы по мере заполнения (классы 30 чел)
                 и назначается классный руководитель*/

            /* Классному руководителю назначается предмет*/

            /* и создается староста*/
            int amountStudent = 500;//500 студентов школа распределяет по классам

            for (int i = 0; i < amountStudent; i++)
            {
                string name = i % 2 == 0 ? "Dima" : "Sveta";
                school.addStudent(new Student($"Student{i}", name, 2000 + (i % 10), (Sex)(i % 2)));
            }

            Console.WriteLine(school);




            

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



}