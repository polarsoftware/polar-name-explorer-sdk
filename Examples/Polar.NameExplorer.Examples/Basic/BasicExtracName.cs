using System;
using System.Linq;
using Polar.PersonNameExtractor;

namespace Polar.NameExplorer.Examples
{
    public class BasicExtracName
    {
        public static void Run()
        {
            Analytics analytics = new Analytics();
            ResultNames resultNames = analytics.ExtractNames("My name is Rebecca Armstrong, I'm from London.");
            ParseName parseName = resultNames.ParseNames.FirstOrDefault();

            Console.WriteLine(parseName.FirstName + " " + parseName.LastName);//"Rebecca Armstrong"
            Console.WriteLine(parseName.FirstName);//"Rebecca"
            Console.WriteLine(parseName.LastName);//"Armstrong"
            Console.WriteLine(parseName.GenderData.Gender);//"f"            
        }        
    }
}
