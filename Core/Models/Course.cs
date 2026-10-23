
using WestcoastEducation.Interfaces;

namespace WestcoastEducation.Core.Models;

public class Course : IPresentation
{
    public string CourseNumber { get; set; } = "";
    public string Title { get; set; } = "";
    public int Length { get; set; } // antal veckor
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }


    public virtual string Present()
    {
        return $"{CourseNumber} ," +
               $"Titel: {Title} ," +
               $"Längd: {Length} veckor ," +
               $"Start: {StartDate:yyyy-MM-dd} ," +
               $"Slut: {EndDate:yyyy-MM-dd} ";
    }
}