
using WestcoastEducation.Core.Models;
using WestcoastEducation.Interfaces;

namespace WestcoastEducation.Core.Models;

public class Teacher : PersonalInfo, IPresentation
{
    public string KnowledgeArea { get; set; } = "";

    public virtual string Present()
{
    return $"{FirstName} {SurName} - {KnowledgeArea} ";
}
}