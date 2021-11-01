using System;
using System.Linq;
using Polar.PersonNameExtractor;

namespace Polar.NameExplorer.Examples
{
    public class CountryDataInfo
    {
        public static void Run()
        {
            Console.WriteLine("");
            Console.WriteLine("CountryDataInfo:");
            //Licenser.RegisterLicense("x");//some invalide key
            Analytics analytics = new Analytics();
            ResultNames resultNames = analytics.ParseName("Mary Johnson");
            ParseName parseName = resultNames.ParseNames.FirstOrDefault();

            Console.WriteLine($"Full Name: {parseName.FirstName + " " + parseName.LastName}");//"Mary Johnson"
            Console.WriteLine($"FirstName: {parseName.FirstName}");//"Mary"
            Console.WriteLine($"LastName: {parseName.LastName}");//"Johnson"
                        
            //Country FirstName  
            Console.WriteLine($"Country: {parseName.CountryData.FirstNameCountryPhrases.First().CountryElements.First().Country}");
            Console.WriteLine($"Frequency: {parseName.CountryData.FirstNameCountryPhrases.First().CountryElements.First().Frequency}");
            Console.WriteLine($"Certainty: {parseName.CountryData.FirstNameCountryPhrases.First().CountryElements.First().Certainty}");
            Console.WriteLine($"Percent: {parseName.CountryData.FirstNameCountryPhrases.First().CountryElements.First().Percent}");

            //Country FirstName              
            Console.WriteLine($"Country: {parseName.CountryData.LastNameCountryPhrases.First().CountryElements.First().Country}");
            Console.WriteLine($"Frequency: {parseName.CountryData.LastNameCountryPhrases.First().CountryElements.First().Frequency}");
            Console.WriteLine($"Certainty: {parseName.CountryData.LastNameCountryPhrases.First().CountryElements.First().Certainty}");
            Console.WriteLine($"Percent: {parseName.CountryData.LastNameCountryPhrases.First().CountryElements.First().Percent}");
        }
    }
}
