using System;
using DialingCodesApp;
public class MainClass{
    public static void Main(string[] args){
        Dictionary<int, string> emptyDict = DialingCodes.GetEmptyDictionary();
        Console.WriteLine("Empty dictionary created.");

        emptyDict = DialingCodes.AddCountryToEmptyDictionary(44, "United Kingdom");
        Console.WriteLine("Added country to empty dictionary.");

        Dictionary<int, string> dict = DialingCodes.GetExistingDictionary();
        Console.WriteLine("\nExisting Dictionary:");

        foreach (var item in dict)
        {
            Console.WriteLine($"{item.Key} -> {item.Value}");
        }

        DialingCodes.AddCountryToExistingDictionary(dict, 81, "Japan");

        int searchCode = 91;
        Console.WriteLine($"\nDoes code {searchCode} exist? " +
            DialingCodes.CheckCodeExists(dict, searchCode));

        Console.WriteLine($"Country for code 91: " +
            DialingCodes.GetCountryName(dict, 91));

        DialingCodes.UpdateDictionary(dict, 55, "Brazil (Updated)");

        DialingCodes.RemoveCountry(dict, 1);

        Console.WriteLine("\nLongest Country Name: " +
            DialingCodes.LongestCountryName(dict));

        Console.WriteLine("\nFinal Dictionary:");
        foreach (var item in dict)
        {
            Console.WriteLine($"{item.Key} -> {item.Value}");
        }
    }
}