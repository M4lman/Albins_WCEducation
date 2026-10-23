
using WestcoastEducation.Interfaces;
using WestcoastEducation.Core.Models;

namespace WestcoastEducation.Core.Models;

public class Education_Manager : Teacher, IPresentation
{
    public DateTime EmploymentDate { get; set; }


    public override string Present()
    {
        return $"Utbildningsledare: {FirstName} {SurName} " +
               $"Telefon: {PhoneNr} " +
               $"Kunskapsområde: {KnowledgeArea} " +
               $"Anställd sedan: {EmploymentDate:yyyy-MM-dd} ";
    }
}