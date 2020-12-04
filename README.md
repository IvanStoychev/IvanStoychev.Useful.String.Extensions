<h1 align="center">
  <br>
  <a href="https://www.nuget.org/packages/IvanStoychev.StringExtensions"><img src="https://imgur.com/8bTHOdq.png" alt="Markdownify"></a>
  <br>
  IvanStoychev.StringExtensions
  <br>
</h1>

<p align="center">
  <a href="https://github.com/IvanStoychev/IvanStoychev.StringExtensions/graphs/commit-activity">
    <img src="https://img.shields.io/github/commit-activity/y/IvanStoychev/IvanStoychev.StringExtensions?style=plastic"
         alt="GitHub commit activity">
  </a>
  <a href="https://github.com/IvanStoychev/IvanStoychev.StringExtensions/branches">
    <img src="https://img.shields.io/github/last-commit/IvanStoychev/IvanStoychev.StringExtensions?style=plastic"
         alt="GitHub last commit">
  </a>
  <a href="https://github.com/IvanStoychev/IvanStoychev.StringExtensions/graphs/commit-activity">
    <img src="https://img.shields.io/github/commits-since/IvanStoychev/IvanStoychev.StringExtensions/latest?style=plastic"
         alt="GitHub commits since latest release (by date)">
  </a>
 <br> 
  <a href="https://www.nuget.org/packages/IvanStoychev.StringExtensions">
    <img src="https://img.shields.io/nuget/v/IvanStoychev.StringExtensions?style=plastic"
         alt="Nuget latest version">
  </a>
  <a href="https://github.com/IvanStoychev/IvanStoychev.StringExtensions/releases">
    <img src="https://img.shields.io/github/v/release/IvanStoychev/IvanStoychev.StringExtensions?style=plastic"
         alt="GitHub latest release">
  </a>
  <a href="https://github.com/IvanStoychev/IvanStoychev.StringExtensions/blob/master/LICENSE">
    <img src="https://img.shields.io/github/license/IvanStoychev/IvanStoychev.StringExtensions?style=plastic"
         alt="Project license">
  </a>
</p>

<h4 align="center">A collection of methods designed to make your life easier.</h4>
<h5 align="center">This repo uses <a href="https://semver.org/#semantic-versioning-200">Semantic Versioning 2.0.0</a></h5>

<p align="center">
  <a href="#-join-the-community">Community</a> •
  <a href="#sparkling_heart-support-the-project">Support</a> •
  <a href="#-introduction">Introduction</a> •
  <a href="#-features">Features</a> •
  <a href="#-installation">Installation</a> •
  <a href="#ℹ-how-to-use">How to use</a> •
  <a href="#-documentation">Documentation</a> •
  <a href="#-contribution">Contribution</a>
</p>

<br/>

# 💬 Join the community
[![Check out the discussion at https://gitq.com/IvanStoychev/IvanStoychev.StringExtensions](https://gitq.com/badge.svg)](https://gitq.com/IvanStoychev/IvanStoychev.StringExtensions)
[![Join the chat at https://gitter.im/IvanStoychev-StringExtensions/community](https://badges.gitter.im/IvanStoychev-StringExtensions/community.svg)](https://gitter.im/IvanStoychev-StringExtensions)
[![Tweet @ivan_stoychev](https://img.shields.io/twitter/url?label=Twitter&style=social&url=https%3A%2F%2Ftwitter.com%2Fivan_stoychev)](https://twitter.com/ivan_stoychev)

<br/>

# :sparkling_heart: Support the project
[![Support me on Patreon](https://img.shields.io/badge/Patreon-support-orange)](https://www.patreon.com/IvanStoychev)
[![Buy me a ko-fi](https://img.shields.io/badge/Buy%20me%20a-Ko--fi-green)](https://ko-fi.com/U7U31XQ28)
[![Sponsor me with PayPal](https://img.shields.io/badge/PayPal-sponsor-blue)](https://www.paypal.com/paypalme/IvanStoychevProjects)
[![Buy me a coffee](https://img.shields.io/badge/Buy%20me%20a-coffee-brown)](https://www.buymeacoffee.com/IvanStoychev)

<br/>

📣 Introduction
------------
This is a collection of string extension methods that I have been in need of many a time, so I bundled them in a nuget package and published the code here. They are designed to be "ease-of-life" and "generally making your life easier" methods with user comfort in mind, which is why there are numerious overloads, designed for every case I could think of.

<br/>

📰 Features
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

🏗 Installation
------------
__*Install using "NuGet Package Manager" in Visual Studio*__
<br/>1. Open the solution to which you wish to add the library.
<br/>2. Open the "_NuGet Package Manager_".

* Option 1 (allows installation to multiple projects in the solution)
<br/>In "_Solution Explorer_" right-click the solution and choose "_Manage NuGet Packages for Solution..._".
* Option 2 (allows installation to multiple projects in the solution)
<br/>Click the "_Tools_" menu bar item, navigate to "_NuGet Package Manager_" and select "_Manage NuGet Packages for Solution..._".
* Option 3 (allows installation only to a single project)
<br/>Right-click the project, to which you wish to add the library, and choose "_Manage NuGet Packages..._".

<br/>3. Make sure your "_Package source:_" (found in the upper-right corner) is pointing to a nuget source that has the library in its catalogue, for example "_nuget.org_". 
<br/>4. Make sure you're in the "_Browse_" section (located in the upper-left corner).
<br/>5. Enter "_IvanStoychev.StringExtensions_" in the search box.
<br/>6. Select the "_IvanStoychev.StringExtensions_" package and choose a version to intall.
<br/>6.1. If you've opened the Package Manager using option 1 or 2 you can select which projects to install the library to.
<br/>7. Click the "_Install_" button and read the licence terms. Choose whether you agree to them or not.

<br/>

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

ℹ How to use
----------
Since the functionality, added by this project, is all extension methods, it would be best to add the using statment "`using IvanStoychev.StringExtensions;`" to your code, as Intellisense usually doesn't pick it up.

After that simply call any desired method on any string.

<br/>

📖 Documentation
-------------
The methods in the package and project have ample summary information, you can also consult the [Wiki][3].

<br/>

🧙‍ Contribution
-------------
Feel free to make issues and pull requests about anything.


  [2]: https://github.com/IvanStoychev/IvanStoychev.StringExtensions/releases
  [3]: https://github.com/IvanStoychev/IvanStoychev.StringExtensions/wiki/
  [4]: https://www.nuget.org/packages/IvanStoychev.StringExtensions/
  [5]: https://github.com/IvanStoychev/IvanStoychev.StringExtensions/packages
  [6]: https://github.com/IvanStoychev/IvanStoychev.StringExtensions/wiki/Remover
  [7]: https://github.com/IvanStoychev/IvanStoychev.StringExtensions/wiki/Comparer
  [8]: https://github.com/IvanStoychev/IvanStoychev.StringExtensions/wiki/Replacer
  [9]: https://github.com/IvanStoychev/IvanStoychev.StringExtensions/wiki/Selector
