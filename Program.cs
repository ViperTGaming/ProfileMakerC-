using System;
using System.Collections.Generic;

public class Profile
{
    public string Name { get; set;}
    public string Age { get; set;}
    public string City{ get; set;}
    public string Country{ get; set;}
    public List<string> Hobbies { get; set;}

public Profile(string name, string age, string city, string country)
{
    Name = name;
    Age = age;
    City = city;
    Country = country;
    Hobbies = new List<string>();
}

public void SetHobbies(string hobby)
{
    Hobbies.Add(hobby);
}

public void viewprofile()
{
    Console.WriteLine($"Name: {Name}\nAge: {Age}\nCity: {City}\nCountry: {Country}");
    Console.WriteLine("Hobbies:");
    foreach (string hobby in Hobbies)
    {
        Console.WriteLine(hobby);
    }
}
}
class Program {

    public static void Main(){
        Console.WriteLine("Welcome to the Profile Creator");
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter your age:");
        string age = Console.ReadLine();
        Console.WriteLine("Enter your city:");
        string city = Console.ReadLine();
        Console.WriteLine("Enter your country:");
        string country = Console.ReadLine();
        Profile profile = new Profile(name, age, city, country);
        AddHobbies(profile);
    }

    public static void AddHobbies(Profile profile)
    {
        Console.WriteLine("Enter your hobbies (type 'done' when finished):");
        while (true)
        {
            string hobby = Console.ReadLine();
            if (hobby != "done" && hobby != "view")
            {
                profile.SetHobbies(hobby);
            }
            else if (hobby == "view")
            {
                profile.viewprofile();
            }
            else
            {
                break;
            }
            
        }
    }

}
