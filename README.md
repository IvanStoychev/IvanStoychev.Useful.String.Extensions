![IvanStoychev.StringExtensions](https://imgur.com/8bTHOdq.png)

# IvanStoychev.StringExtensions
[![GitHub commit activity](https://github.com/IvanStoychev/IvanStoychev.StringExtensions/graphs/commit-activity)](https://img.shields.io/github/commit-activity/m/IvanStoychev/IvanStoychev.StringExtensions?style=plastic&foo=bar)
[![GitHub last commit](https://github.com/IvanStoychev/IvanStoychev.StringExtensions/branches)](https://img.shields.io/github/last-commit/IvanStoychev/IvanStoychev.StringExtensions?style=plastic)
[![GitHub commits since latest release (by date)]((https://github.com/IvanStoychev/IvanStoychev.StringExtensions/graphs/commit-activity))](https://img.shields.io/github/commits-since/IvanStoychev/IvanStoychev.StringExtensions/latest?style=plastic)

[![Nuget](https://www.nuget.org/packages/IvanStoychev.StringExtensions/)](https://img.shields.io/nuget/v/IvanStoychev.StringExtensions?style=plastic)
[![GitHub latest release](https://github.com/IvanStoychev/IvanStoychev.StringExtensions/releases)](https://img.shields.io/github/v/release/IvanStoychev/IvanStoychev.StringExtensions?style=plastic)
![GitHub](https://img.shields.io/github/license/IvanStoychev/IvanStoychev.StringExtensions?style=plastic)
<br/>
A collection of methods designed to make your life easier.

This repo uses [Semantic Versioning 2.0.0][1]

<br/>

# Join the community
[![Check out the discussion at https://gitq.com/IvanStoychev/IvanStoychev.StringExtensions](https://gitq.com/badge.svg)](https://gitq.com/IvanStoychev/IvanStoychev.StringExtensions)
[![Gitter](https://badges.gitter.im/IvanStoychev-StringExtensions/community.svg)](https://gitter.im/IvanStoychev-StringExtensions/community?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge)

<br/>

# Support the project
[![Support me on Patreon](https://img.shields.io/badge/Patreon-support-orange)](https://www.patreon.com/IvanStoychev)

<br/>

Introduction
------------
This is a collection of string extension methods that I have been in need of many a time, so I bundled them in a nuget package and published the code here. They are designed to be "ease-of-life" and "generally making your life easier" methods with user comfort in mind, which is why there are numerious overloads, designed for every case I could think of.

<br/>

Features
------------
* Methods to keep or remove all special characters, letters and digits from a string.
  * Ex. `"!#%&lorem^@ipsum!@%".KeepOnlyLetters()` will return `"loremipsum"`.
* [`Remove`][6] methods that take a series of strings or characters and clear all their occurrences from the string with a single method call.
  * Ex. `"Lorem ipsum dolor Lorem ipsum sit amet".Remove("Lorem ", "ipsum ", "t")` will return `"dolor si ame"`.
* [`Contains`][7] methods that check if a string contains any of a series of provided values.
  * Ex. `"brake wheel icon number stoic".Contains("keen", "wild", "icon")` will return `true`.
* [`TrimStart`][6] and [`TrimEnd`][6] methods that take a string and remove it from the start or end of the original string.
  * Ex. `"In the beginning there was an end".TrimStart("In the beginning ")` will return `"there was an end"`, while `"In the beginning there was an end".TrimEnd(" an end")` will produce `"In the beginning there was"`.
* [`Replace`][8] methods that take a series of strings or characters and replace all their occurrences in the original string with a provided value.
  * Ex. `"Cucumbers, oranges and apples are vegetables.".Replace("tomatoes", "oranges", "apples")` will return `"Cucumbers, tomatoes and tomatoes are vegetables."`.
* [`Substring`][9] methods that use string arguments to determine a substring's position, instead of a starting index.
  * Ex. `"This is the start bla bladdy blah.".Substring("start ", false)` will return `"bla bladdy blah."`, while `"This is the start bla bladdy blah and this is the end.".Substring("start ", "blah", StringInclusionOptions.IncludeNone)` will return `"bla bladdy "`.

<br/>

Installation
------------
__*Install manually*__
<br/>1.a. Download the package from [NuGet][4], [Github packages][5] or the [Releases][2] page.
<br/>-or-
<br/>1.b. Clone the repo and build in it "Release" mode, which will produce a package file in the project's release dir - "~\IvanStoychev.StringExtensions\IvanStoychev.StringExtensions\bin\Release".
<br/>2. Make sure you have the .NET CLI installed.
<br/>3. Open a command line and Run the command `dotnet add <PROJECT> package <PACKAGE>`.
<br/>where:
<br/>*\<PROJECT\>* is the path to the \*.csproj file to which you want to add the package (if it is located in the command line's working directory you can omit this parameter).
<br/>*\<PACKAGE\>* is the path to the package you have downloaded.
<br/>
<br/>__*Install using "Package Manager Console"*__
<br/>1. Run this command in the "Package Manager Console": `Install-Package IvanStoychev.StringExtensions`.
<br/>
<br/>__*Install using PackageReference*__
<br/>1. Add this line, in an "*\<ItemGroup>*", to your .csproj file `<PackageReference Include="IvanStoychev.StringExtensions" Version="VersionNumber"/>`.
<br/>where:
<br/>*VersionNumber* is the version of the package you wish to use, e.g. `1.0.0`.
<br/>
<br/>__*Install using Paket CLI*__
<br/>1. Run the command `paket add IvanStoychev.StringExtensions`.

<br/>

How to use
----------
Since the functionality, added by this project, is all extension methods, it would be best to add the using statment "`using IvanStoychev.StringExtensions;`" to your code, as Intellisense usually doesn't pick it up.

After that simply call any desired method on any string.

<br/>

Documentation
-------------
The methods in the package and project have ample summary information, you can also consult the [Wiki][3].

<br/>

Contribution
-------------
Feel free to make issues and pull requests about anything.


  [1]: https://semver.org/#semantic-versioning-200
  [2]: https://github.com/IvanStoychev/IvanStoychev.StringExtensions/releases
  [3]: https://github.com/IvanStoychev/IvanStoychev.StringExtensions/wiki/
  [4]: https://www.nuget.org/packages/IvanStoychev.StringExtensions/
  [5]: https://github.com/IvanStoychev/IvanStoychev.StringExtensions/packages
  [6]: https://github.com/IvanStoychev/IvanStoychev.StringExtensions/wiki/Remover
  [7]: https://github.com/IvanStoychev/IvanStoychev.StringExtensions/wiki/Comparer
  [8]: https://github.com/IvanStoychev/IvanStoychev.StringExtensions/wiki/Replacer
  [9]: https://github.com/IvanStoychev/IvanStoychev.StringExtensions/wiki/Selector
