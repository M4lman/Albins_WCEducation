using WestcoastEducation.Core.Models;
using WestcoastEducation.Core.Services;


namespace WestcoastEducation.Client;

class Program
{

    static void Main(string[] args)
    {
    Local local = new Local();
    local.LoadCourses();
        bool running = true;

        while (running)
        {
            Console.Clear();

            Console.WriteLine("           Välkommen");
            Console.WriteLine("             till");
            Console.WriteLine("      Westcoast Education");
            Console.WriteLine();
            Console.WriteLine("    tryck 1-7 eller x för val");
            Console.WriteLine();
            Console.WriteLine("1: Lägg till kurs");
            Console.WriteLine("2: Lägg till student");
            Console.WriteLine("3: Lägg till lärare");
            Console.WriteLine("4: Lägg till utbildningsledare");
            Console.WriteLine("5: Lägg till admin");
            Console.WriteLine("6: Lista kurser");
            Console.WriteLine("7: Lista studenter");
            Console.WriteLine("x: Avsluta");
            Console.WriteLine();
            

            string choice = Console.ReadLine()!;


            switch (choice)
            {
                case "1":
                    Course course = new Course();

                    Console.Write("Kursnummer: ");
                    course.CourseNumber = Console.ReadLine()!;

                    Console.Write("Titel: ");
                    course.Title = Console.ReadLine()!;

                    Console.Write("Längd (veckor): ");
                    course.Length = int.Parse(Console.ReadLine()!);

                    Console.Write("Startdatum (yyyy-mm-dd): ");
                    course.StartDate = DateTime.Parse(Console.ReadLine()!);

                    Console.Write("Slutdatum (yyyy-mm-dd): ");
                    course.EndDate = DateTime.Parse(Console.ReadLine()!);

                    local.AddCourse(course);

                    Console.WriteLine("Kurs tillagd!");
                    break;


                case "2":
                
                    Student student = new Student();

                    Console.Write("Förnamn: ");
                    student.FirstName = Console.ReadLine()!;
                    Console.Write("Efternamn: ");
                    student.SurName = Console.ReadLine()!;
                    Console.Write("Personnummer: ");
                    student.PINr = Console.ReadLine()!;
                    Console.Write("Telefon: ");
                    student.PhoneNr = Console.ReadLine()!;

                    local.AddStudent(student);
                    break;


                case "3":
                    Teacher teacher = new Teacher();
                    Console.Write("Förnamn: ");
                    teacher.FirstName = Console.ReadLine()!;
                    Console.Write("Efternamn: ");
                    teacher.SurName = Console.ReadLine()!;
                    Console.Write("Personnummer: ");
                    teacher.PINr = Console.ReadLine()!;
                    Console.Write("Telefon: ");
                    teacher.PhoneNr = Console.ReadLine()!;
                    Console.Write("Kunskapsområde: ");
                    teacher.KnowledgeArea = Console.ReadLine()!;

                    local.AddTeacher(teacher);
                    break;


                case "4":
                    Education_Manager manager = new Education_Manager();

                    Console.Write("Förnamn: ");
                    manager.FirstName = Console.ReadLine()!;
                    Console.Write("Efternamn: ");
                    manager.SurName = Console.ReadLine()!;
                    Console.Write("Personnummer: ");
                    manager.PINr = Console.ReadLine()!;
                    Console.Write("Telefon: ");
                    manager.PhoneNr = Console.ReadLine()!;
                    Console.Write("Kunskapsområde: ");
                    manager.KnowledgeArea = Console.ReadLine()!;
                    Console.Write("Anställningsdatum (yyyy-mm-dd): ");
                    manager.EmploymentDate = DateTime.Parse(Console.ReadLine()!);

                    local.AddEducationManager(manager);
                    break;


                case "5":
                    Admin admin = new Admin();

                    Console.Write("Förnamn: ");
                    admin.FirstName = Console.ReadLine()!;
                    Console.Write("Efternamn: ");
                    admin.SurName = Console.ReadLine()!;
                    Console.Write("Personnummer: ");
                    admin.PINr = Console.ReadLine()!;
                    Console.Write("Telefon: ");
                    admin.PhoneNr = Console.ReadLine()!;
                    Console.Write("Anställningsdatum (yyyy-mm-dd): ");
                    admin.EmploymentDate = DateTime.Parse(Console.ReadLine()!);


                    local.AddAdmin(admin);

                    Console.WriteLine("Administratör tillagd!");
                    break;


                case "6":
                    local.ListCourseinfo();
                    break;


                case "7":
                    local.ListStudentInfo();
                    break;


                case "x":
                    running = false;
                    break;


                default:
                    Console.WriteLine("Felaktigt val");
                    break;
            }


            if (running)
            {
                Console.WriteLine("Tryck på valfri tangent...");
                Console.ReadKey();
            }
        }
    }
}