using System;
using System.Collections.Generic;

namespace FamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();
            myFamily.Add("Brother", new Dictionary<string, string>() { { "name", "Emmanuel" }, { "age", "27" } });
            myFamily.Add("Mother", new Dictionary<string, string>() { { "name", "Annie" }, { "age", "60" } });
            myFamily.Add("Father", new Dictionary<string, string>() { { "name", "Charles" }, { "age", "60" } });

            foreach(var member in myFamily)
            {
                var name = member.Value["name"];
                var age = member.Value["age"];
                Console.WriteLine($"{name} is my {member.Key} and is {age} years old.");
            }

        }
    }
}
