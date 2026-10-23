using System;

namespace WestcoastEducation.Core.Models;

public class PersonalInfo //Personlig Information
{
public string FirstName { get; set; } = "";
public string SurName { get; set; } = "";
public string PINr { get; set; } = "";
public string PhoneNr { get; set; } = "";
public string? Adress {get; set;}
public string? ZIPCode {get; set;}
public string? City {get; set;}

    public override string ToString()
    {
        return $"   {FirstName} {SurName} ({PINr}), tel: {PhoneNr}, Adress {Adress} {City} {ZIPCode} ";
    }
}
