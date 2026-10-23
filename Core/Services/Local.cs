using WestcoastEducation.Core.Models;
using System.Text.Json;

namespace WestcoastEducation.Core.Services;

public class Local
{
    private List<Course> courses = new();
    private List<Student> students = new();
    private List<Teacher> teachers = new();
    private List<Education_Manager> educationManagers = new();
    private List<Admin> adminis = new();



    // Lägg till student
    public void AddStudent(Student student)
    {
        students.Add(student);
    }

    // Lista studenter
    public void ListStudentInfo()
    {
        foreach (Student student in students)
        {
            Console.WriteLine(student.Present());
        }
    }


    // Lägg till lärare
    public void AddTeacher(Teacher teacher)
    {
        teachers.Add(teacher);
    }

    public void AddEducationManager(Education_Manager manager)
    {
        educationManagers.Add(manager);
    }

    public void AddAdmin(Admin admin)
    {
        adminis.Add(admin);
    }

    

    // Lägg till kurs
    public void AddCourse(Course course)
    {
        courses.Add(course);
        SaveCourses();
    }


    // Lista kurser
    public void ListCourseinfo()
    {
        foreach (Course course in courses)
        {
            Console.WriteLine(course.Present());
        }
    }

    private string courseFile = "Data/courses.json";
    public void SaveCourses()
    {
        string json = JsonSerializer.Serialize(courses);

        File.WriteAllText(courseFile, json);
    }
    public void LoadCourses()
{
    if (File.Exists(courseFile))
    {
        string json = File.ReadAllText(courseFile);

        if (!string.IsNullOrWhiteSpace(json))
        {
            courses = JsonSerializer.Deserialize<List<Course>>(json) ?? new();
        }
    }
}

}