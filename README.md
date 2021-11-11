# Polar Name Explorer SDK 
***(The product is in the release candidate phase. Contact: [getting help](#getting-help) or support@polarsoftware.com)***

The **Polar Name Explorer SDK** enables .NET developers to easily work with **Polar Name Explorer .NET Core Component**.

The **SDK** is an easy-to-use infrastructure containing developer focused examples, documentation (GitHub Wiki) and official bug tracker (GitHub Issues).

**Polar Name Explorer .NET Core Component** is an class library allows your .NET applications to extract and parse names and surnames from text, get the gender of the name, and country of origine.

This is a paid commercial product. 
You can try this NuGet package for free for 30 days, after which you will need to purchase a license key to continue using it.  
Version below 1.0 is the release candidate version and is not for commercial use.  
Supported platforms: ![Version](https://img.shields.io/badge/.NET_Core->=_5-blue)


* [Getting started](#getting-started) <!-- * [Key concepts](#key-concepts) -->
* [Examples ](#examples)
* [Getting Help](#getting-help)
* [Opening Issues](#opening-issues)
* [Trial version and commercial license](#Trial-Version-and-Commercial-License) 
* [SDK Developer Guide, documentation][wiki-docs]
* [SDK Examples][sdk-examples]

## Getting started

### Install the package
<!-- 
You can download Nuget package from this link: [http://download.polarsoftware.com/nameexplorer/Polar.Name.Explorer.nupkg.zip](http://download.polarsoftware.com/nameexplorer/Polar.Name.Explorer.nupkg.zip).    
Right-click on the link and select "Save link as...".   
Here is instruction [how to install a NuGet package .nupkg file locally?](https://stackoverflow.com/questions/10240029/how-do-i-install-a-nuget-package-nupkg-file-locally)
  
This is a trial, release candidate version, when we launch the release version it will be available on the nuget.org web site.

Recommended way of trial library usage is to install it via [NuGet](https://www.nuget.org/downloads) Package Manager.
 https://www.nuget.org/packages/PolarNameExplorer/
#### Package Manager UI
Within Visual Studio, use the Package Manager UI to browse for `PolarNameExplorer` package and install to your project.
-->


#### .NET CLI
Install the package via .NET CLI,use  the following command:

    dotnet add package PolarNameExplorer

### Package reference
To including the package directly into project file:

    <PackageReference Include="PolarNameExplorer" Version="0.8.7" />

#### Package Manager Console
Within Visual Studio, use the Package Manager Console command:

    Install-Package PolarNameExplorer
   
**NuGet.org** repository link:  
[![Nuget](https://img.shields.io/nuget/v/PolarNameExplorer)](https://www.nuget.org/packages/PolarNameExplorer/) [![Nuget](https://img.shields.io/nuget/dt/PolarNameExplorer)](https://www.nuget.org/packages/PolarNameExplorer/)

<!-- 
## Key concepts    
(todo)
-->
## Examples 
The following sections provide several code snippets covering some of the most common Polar Name Explorer tasks, including:
* [Extract name from text](#extract-name-from-text)
* [Parse full name](#parse-full-name)

### Extract name from text
```C#
Analytics analytics = new Analytics();
ResultNames resultNames = analytics.ExtractNames("My name is Mary Johnson, I'm from London, England ex-Europe.");
ParseName parseName = resultNames.ParseNames.FirstOrDefault();
Console.WriteLine($"Full Name: {parseName.FirstName + " " + parseName.LastName}");//"Mary Johnson"
Console.WriteLine($"FirstName: {parseName.FirstName}");//"Mary"
Console.WriteLine($"LastName: {parseName.LastName}");//"Johnson"
//Gender:            
Console.WriteLine($"Gender: {parseName.GenderData.Gender}");//"f"            
Console.WriteLine($"FemalePercent: {parseName.GenderData.FemalePercent}");
Console.WriteLine($"MalePercent: {parseName.GenderData.MalePercent}");
```
[source of example](https://github.com/polarsoftware/polar-name-explorer-sdk/blob/main/Examples/Polar.NameExplorer.Examples/Basic/BasicExtracName.cs)

### Parse full name
 ```C#
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
```
[source of example](https://github.com/polarsoftware/polar-name-explorer-sdk/blob/main/Examples/Polar.NameExplorer.Examples/Basic/BasicParseName.cs)
<!--- <sub><sup> Small text </sup></sub> --->

### Demo website  
Try the functionality of the component through this demo website that uses the relase version of the component:  
http://nameapp.polarsoftware.com


## Troubleshooting
### Exception handling

**Polar Name Explorer .NET Core Component**
A exception is triggered when an operation specific to Polar Name Explorer has encountered an issue. The exception includes some contextual information to assist in understanding the context of the error and its relative severity. 

## Getting Help
Please use these community resources for getting help. We use the [GitHub issues][sdk-issues] for tracking bugs and feature requests.

* If it turns out that you may have found a bug, please open an [issue via Github Issues][sdk-issues].
* Suggest an idea for this product, open [feature request][sdk-issues].
* For tutorials, quick starts, and other documentation, go to [Wiki documentation][wiki-docs].
* For Examples, go to [examples][sdk-examples].
* Ask a question on [StackOverflow](http://stackoverflow.com/) and tag it with polar-name-explorer.
<!--- * File an issue via Github Issues.
* Open a support ticket with Polar Support ( support@polarsoftware.com ).  --->

### Opening Issues
Opening Issues
If you encounter a bug with **Polar Name Explorer SDK** we would like to hear about it. 
Search the existing [issues][sdk-issues] and try to make sure your problem doesn’t already exist before opening a new issue. 
It’s helpful if you include the version of **Polar Name Explorer SDK** and the OS you’re using. 
Please include a stack trace and reduced repro case when appropriate, too.

The [GitHub issues][sdk-issues] are intended for bug reports and feature requests. 
For help and questions with using **Polar Name Explorer SDK**  please make use of the resources listed in the Getting Help section. 
There are limited resources available for handling issues and by keeping the list of open issues clean we can respond in a timely manner.

## Trial version and commercial license
**Polar Name Explorer .NET Core Component** is a commercial library.  You are welcome to explore its functionality and get technical support from the team when you download  this trial version.   
Trial version has some limits such as: 30 days, uses only US name list, etc. 
<!---  You are welcome to explore its full functionality and get technical support from the team when you register for a free 30-day trial.   --->
To use it commercially, you need to purchase a license (when we launch the release version). Feel free to review the Polar License Agreement to get acquainted with the full terms of use.  
The libraries are subject of the license under which you've obtained the assemblies.

**Website with a fully functional version of the component**   
You can try the full functionality of the component, release version, no trial version, on the website:   
http://nameapp.polarsoftware.com

## Note
***Currently, the product is in the release candidate phase.***  
This repository does not contain the actual source code of the components.    

Follow the information here on the GitHub repository [Polar Name Explorer SDK](https://github.com/polarsoftware/polar-name-explorer-sdk).  
If you have any questions feel free to contact us: support@polarsoftware.com, or find anything you want to know here: [issues](https://github.com/polarsoftware/PolarNameExplorerCommunity/issues).
<!--- Follow the information here on the GitHub repository **Polar Name Explorer SDK** and on the [website](http://name.polarsoftware.com/index.html) -->

### Licensing in brief
Commercial, 100% royalty free distribution, for desktop and server.   
Polar Name Explorer .NET Core Component is an commercial class library: [License link](https://www.nuget.org/packages/PolarNameExplorer/0.8.7/License)  
[![License: Commercial](https://img.shields.io/badge/License-Commercial-blue.svg)](https://www.nuget.org/packages/PolarNameExplorer/0.8.7/License)   

**SDK** source code examples:  
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT) 


[sdk-issues]: https://github.com/polarsoftware/polar-name-explorer-sdk/issues
[wiki-docs]: https://github.com/polarsoftware/polar-name-explorer-sdk/wiki
[sdk-examples]: https://github.com/polarsoftware/polar-name-explorer-sdk/tree/main/Examples

