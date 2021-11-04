using System;
using System.Linq;

namespace Polar.NameExplorer.Examples
{
    public class BasicParseName
    {
        public static void Run()
        {
            Console.WriteLine("");
            Console.WriteLine("BasicParseName:");

            Analytics analytics = new Analytics();
            ResultNames resultNames = analytics.ParseName("Mary Johnson");
            ParseName parseName = resultNames.ParseNames.FirstOrDefault();

            Console.WriteLine($"Full Name: {parseName.FirstName + " " + parseName.LastName}");//"Mary Johnson"
            Console.WriteLine($"FirstName: {parseName.FirstName}");//"Mary"
            Console.WriteLine($"LastName: {parseName.LastName}");//"Johnson"

            //Position:          
            Console.WriteLine($"Begin: {parseName.Begin}");//"Begin char position of name"            
            Console.WriteLine($"End: {parseName.End }");//"End char position of name"            

            //Gender:            
            Console.WriteLine($"Gender: {parseName.GenderData.Gender}");//"f"            
            Console.WriteLine($"FemalePercent: {parseName.GenderData.FemalePercent}");
            Console.WriteLine($"FemalePercent: {parseName.GenderData.MalePercent}");
        }        
    }
}
