# Polar Name Explorer SDK 

The **Polar Name Explorer SDK** enables .NET developers to easily work with **Polar Name Explorer .NET Core Component**.

The **SDK** is an easy-to-use infrastructure containing developer focused examples, documentation (GitHub Wiki) and official bug tracker (GitHub Issues).

**Polar Name Explorer .NET Core Component** is the perfect solution to all your name extraction problems.
It is an easy-to-use .NET Core component, ideal for software developers who want to extract and parse names, surnames from text.

* [Get Started](#get-started)
* [Getting Help](#getting-help)
* [Opening Issues](#opening-issues)
* [SDK Developer Guide, documentation](https://github.com/polarsoftware/PolarNameExplorerCommunity/wiki)
* [SDK Examples](https://github.com/polarsoftware/PolarNameExplorerCommunity/tree/main/Examples)

## Get Started
#### Quciks Example  
```C#
using Polar.PersonNameExtractor;

NameExtractor nameExtractor = new NameExtractor();
var names = nameExtractor.ExtractNames("My name is Rebecca Armstrong, I'm from London.");
var name = names.FirstOrDefault();

Console.WriteLine(name.PersonNameData.FullName);//"Rebecca Armstrong"
Console.WriteLine(name.PersonNameData.First);//"Rebecca"
Console.WriteLine(name.PersonNameData.Last);//"Armstrong"
```

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

## Note
This repository does not contain the actual source code of the components.
More info soon at [web site](http://name.polarsoftware.com/index.html)
If you have any questions feel free to contact us: support@polarsoftware.com, or find anything you want to know here: [issues](https://github.com/polarsoftware/PolarNameExplorerCommunity/issues).

### Licensing in brief
100% royalty free distribution, for desktop and server.

[sdk-issues]: https://github.com/polarsoftware/PolarNameExplorerCommunity
[wiki-docs]: https://github.com/polarsoftware/PolarNameExplorerCommunity
[sdk-examples]: https://github.com/polarsoftware/PolarNameExplorerCommunity

