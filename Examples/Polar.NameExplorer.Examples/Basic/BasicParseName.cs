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
        }        
    }
}
