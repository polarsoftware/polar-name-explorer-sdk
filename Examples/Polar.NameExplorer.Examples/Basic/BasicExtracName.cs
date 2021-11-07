using System;
using System.Linq;

namespace Polar.NameExplorer.Examples
{
    public class BasicExtracName
    {
        public static void Run()
        {            
            Console.WriteLine("\nBasic Extract Name:");

            Analytics analytics = new Analytics();
            ResultNames resultNames = analytics.ExtractNames("My name is Mary Johnson, I'm from London, England ex-Europe.");
            ParseName parseName = resultNames.ParseNames.FirstOrDefault();

            Console.WriteLine($"Full Name: {parseName.FirstName + " " + parseName.LastName}");//"Mary Johnson "
            Console.WriteLine($"FirstName: {parseName.FirstName}");//"Mary"
            Console.WriteLine($"LastName: {parseName.LastName}");//"Johnson"

            //Gender:            
            Console.WriteLine($"Gender: {parseName.GenderData.Gender}");//"f"            
            Console.WriteLine($"FemalePercent: {parseName.GenderData.FemalePercent}");
            Console.WriteLine($"MalePercent: {parseName.GenderData.MalePercent}");

            //Position:          
            Console.WriteLine($"Begin: {parseName.Begin}");//"Begin char position of name"            
            Console.WriteLine($"End: {parseName.End }");//"End char position of name"                        
        }        
    }
}
