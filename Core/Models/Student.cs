using WestcoastEducation.Core.Models;
using WestcoastEducation.Interfaces;

namespace WestcoastEducation.Core.Models;

public class Student : PersonalInfo, IPresentation
{
    public List<Course> Courses { get; set; } = new();

    public string Present()
    {
        return $"{FirstName} {SurName} - {PINr} ";
    }
}