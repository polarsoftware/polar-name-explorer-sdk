# Polar Name Explorer SDK 
***(Currently, the product is in the release candidate phase. Contact: [getting help](#getting-help) or support@polarsoftware.com)***

The **Polar Name Explorer SDK** enables .NET developers to easily work with **Polar Name Explorer .NET Core Component**.

The **SDK** is an easy-to-use infrastructure containing developer focused examples, documentation (GitHub Wiki) and official bug tracker (GitHub Issues).

**Polar Name Explorer .NET Core Component** is the perfect solution to all your name extraction problems.
It is an easy-to-use .NET Core component, ideal for software developers who want to extract and parse names, surnames from text.

* [Getting started](#getting-started)
* [Key concepts](#key-concepts)
* [Examples ](#examples)
* [Getting Help](#getting-help)
* [Opening Issues](#opening-issues)
* [Trial version and commercial license](#Trial-Version-and-Commercial-License) 
* [SDK Developer Guide, documentation][wiki-docs]
* [SDK Examples][sdk-examples]

## Getting started

### Install the package
Recommended way of trial library usage is to install it via [NuGet](https://www.nuget.org/downloads) Package Manager.

#### Package Manager UI
Within Visual Studio, use the Package Manager UI to browse for `Polar.NameExplorer` trial package and install to your project.

#### Package Manager Console
Within Visual Studio, use the Package Manager Console command:

    Install-Package Polar.NameExplorer -Version 1.0.0

#### .NET CLI
Install the package via .NET CLI,use  the following command:

    dotnet add package Polar.NameExplorer --version 1.0.0

### Package reference
To including the package directly into project file:

    <PackageReference Include="Polar.NameExplorer" Version="1.0.0" />
    
## Key concepts    
(todo)

## Examples 
The following sections provide several code snippets covering some of the most common Polar Name Explorer tasks, including:
* [Extract name from text](#extract-name-from-text)
* [Parse full name](#parse-full-name)

 ### Extract name from text
```C#
Analytics analytics = new Analytics();

//Extract name from raw text
ResultNames resultNames = analytics.ExtractNames("My name is Rebecca Armstrong, I'm from London.");
ParseName parseName = resultNames.ParseNames.FirstOrDefault();
Console.WriteLine(parseName.FirstName);//"Rebecca"
Console.WriteLine(parseName.LastName);//"Armstrong"
Console.WriteLine(parseName.GenderData.Gender);//"f"      
```

 ### Parse full name
 ```C#
 Analytics analytics = new Analytics();
 
//Parse full name
ResultNames resultNames = analytics.ParseName("Rebecca Armstrong");            
parseName = resultNames.ParseNames.FirstOrDefault();
Console.WriteLine(parseName.FirstName);//"Rebecca"
Console.WriteLine(parseName.LastName);//"Armstrong"
Console.WriteLine(parseName.GenderData.Gender);//"f"            
```

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
**Polar Name Explorer .NET Core Component** is a commercial library. You are welcome to explore its full functionality and get technical support from the team when you register for a free 30-day trial.   
To use it commercially, you need to purchase a license. Feel free to review the Polar License Agreement to get acquainted with the full terms of use.  
The libraries are subject of the license under which you've obtained the assemblies.

## Note
***Currently, the product is in the release candidate phase.***  
This repository does not contain the actual source code of the components.    
Follow the information here on the GitHub repository **Polar Name Explorer SDK** and on the [website](http://name.polarsoftware.com/index.html)    
If you have any questions feel free to contact us: support@polarsoftware.com, or find anything you want to know here: [issues](https://github.com/polarsoftware/PolarNameExplorerCommunity/issues).

### Licensing in brief
100% royalty free distribution, for desktop and server.

[sdk-issues]: https://github.com/polarsoftware/polar-name-explorer-sdk/issues
[wiki-docs]: https://github.com/polarsoftware/polar-name-explorer-sdk/wiki
[sdk-examples]: https://github.com/polarsoftware/polar-name-explorer-sdk/tree/main/Examples

