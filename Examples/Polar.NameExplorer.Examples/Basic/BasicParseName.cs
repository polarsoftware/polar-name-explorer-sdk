using System;
using System.Linq;
using Polar.PersonNameExtractor;

namespace Polar.NameExplorer.Examples
{
    public class BasicParseName
    {
        public static void Run()
        {
            Analytics nameExtractor = new Analytics();
            string firstName = "Rebecca";
            string lastName = "Armstrong";
            string fullName = $"{firstName} {lastName}";
            ResultNames resultNames = nameExtractor.ParseName(fullName);//"Rebecca Armstrong"
            ParseName parseName = resultNames.ParseNames.FirstOrDefault();

            Console.WriteLine(parseName.FirstName + " " + parseName.LastName);//"Rebecca Armstrong"
            Console.WriteLine(parseName.FirstName);//"Rebecca"
            Console.WriteLine(parseName.LastName);//"Armstrong"
            Console.WriteLine(parseName.GenderData.Gender);//"f"            
        }        
    }
}
