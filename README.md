# Polar Name Explorer Community
Polar Name Explorer .NET Core Component

### Polar Name Explorer - .NET Core Component - Coming Soon!

If you have any questions feel free to contact us: support@polarsoftware.com, or find anything you want to know here: [issues](https://github.com/polarsoftware/PolarNameExplorerCommunity/issues).

**Polar Name Explorer .NET Core Component**  is the perfect solution to all your name extraction problems.  
It is an easy-to-use .NET Core component, ideal for software developers who want to extract and parse names, surnames from text.

### Example
```C#
using Polar.PersonNameExtractor;

NameExtractor nameExtractor = new NameExtractor();
var names = nameExtractor.ExtractNames("My name is Rebecca Armstrong, I'm from London.");
var name = names.FirstOrDefault();

Console.WriteLine(name.PersonNameData.FullName);//"Rebecca Armstrong"
Console.WriteLine(name.PersonNameData.First);//"Rebecca"
Console.WriteLine(name.PersonNameData.Last);//"Armstrong"
```

### Licensing in brief
100% royalty free distribution, for desktop and server.

More info soon at [web site](http://name.polarsoftware.com/index.html)
