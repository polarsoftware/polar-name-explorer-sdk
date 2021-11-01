using System;

namespace Polar.NameExplorer.Examples
{
    class RunExamples
    {
        static void Main(string[] args)
        {
            //Without registered license key assembly will run in trial mode.
            //Licenser.RegisterLicense("xxx");

            BasicExtracName.Run();
            BasicParseName.Run();
            CountryDataInfo.Run();
        }
    }
}
