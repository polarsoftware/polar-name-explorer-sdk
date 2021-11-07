using System;
using System.Linq;

namespace Polar.NameExplorer.Examples
{
    public class BasicParseName
    {
        public static void Run()
        {            
            Console.WriteLine("\nBasic Parse Name:");

            Analytics analytics = new Analytics();
            ResultNames resultNames = analytics.ParseName("Mary Johnson");
            ParseName parseName = resultNames.ParseNames.FirstOrDefault();

            Console.WriteLine($"Full Name: {parseName.FirstName + " " + parseName.LastName}");//"Mary Johnson"
            Console.WriteLine($"FirstName: {parseName.FirstName}");//"Mary"
            Console.WriteLine($"LastName: {parseName.LastName}");//"Johnson"
                        
            //Gender:            
            Console.WriteLine($"Gender: {parseName.GenderData.Gender}");//"f"            
            Console.WriteLine($"FemalePercent: {parseName.GenderData.FemalePercent}");
            Console.WriteLine($"MalePercent: {parseName.GenderData.MalePercent}");
            
            Console.WriteLine("\nCountry First Name:");            
            CountryElement countryElement = parseName.CountryData.FirstNameCountryPhrases.First().CountryElements.First();            
            Console.WriteLine($"Country: {countryElement.Country}");
            Console.WriteLine($"Frequency: {countryElement.Frequency}");
            Console.WriteLine($"Certainty: {countryElement.Certainty}");
            Console.WriteLine($"Percent: {countryElement.Percent}");
                       
            Console.WriteLine("\nCountry Last Name:");            
            countryElement = parseName.CountryData.LastNameCountryPhrases.First().CountryElements.First();            
            Console.WriteLine($"Country: {countryElement.Country}");
            Console.WriteLine($"Frequency: {countryElement.Frequency}");
            Console.WriteLine($"Certainty: {countryElement.Certainty}");
            Console.WriteLine($"Percent: {countryElement.Percent}");
            
        }        
    }
}
