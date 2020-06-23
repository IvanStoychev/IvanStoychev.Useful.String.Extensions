# Useful.String.Extensions
A collection of methods designed to make your life easier.

This repo uses [Semantic Versioning 2.0.0][1]

<br/>

Introduction
------------
This is a collection of string extension methods that I have been in need of many a time, so I bundled them in a nuget package and published the code here. They are designed to be "ease-of-life" and "generally making your life easier" methods with user comfort in mind, which is why there are numerious overloads, designed for every case I could think of.


<br/>

Installation
------------
<br/>*Install manually*
<br/>1.a. Download the package from [NuGet][4], [Github packages][5] or the [Releases][2] page.
<br/>-or-
<br/>1.b. Clone the repo and build in it "Release" mode, which will produce a package file in the project's release dir - "~\Useful.String.Extensions\Useful.String.Extensions\bin\Release".
<br/>2. Make sure you have the .NET CLI installed.
<br/>3. Open a command line and Run the command "`dotnet add <PROJECT> package <PACKAGE>`".
<br/>where:
<br/>*\<PROJECT\>* is the path to the \*.csproj file to which you want to add the package (if it is located in the command line's working directory you can omit this parameter).
<br/>*\<PACKAGE\>* is the path to the package you have downloaded.
<br/>*Install using "Package Manager Console"*
<br/>1. Run this command in the "Package Manager Console": `Install-Package Useful.String.Extensions`.
<br/>
<br/>*Install using PackageReference*
<br/>1. Add this line, in an "*\<ItemGroup>*", to your .csproj file "`<PackageReference Include="Useful.String.Extensions" Version="VersionNumber"/>`".
<br/>where:
<br/>*VersionNumber* is the version of the package you wish to use, e.g. `1.4.0`.
<br/>
<br/>*Install using Paket CLI*
<br/>1. Run the command "`paket add Useful.String.Extensions`".

<br/>

How to use
----------
Since the functionality, added by this project, is all extension methods, it would be best to add the using statment "`using Useful.String.Extensions;`" to your code, as Intellisense usually doesn't pick it up.

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
  [2]: https://github.com/IvanStoychev/Useful.String.Extensions/releases
  [3]: https://github.com/IvanStoychev/Useful.String.Extensions/wiki/
  [4]: https://www.nuget.org/packages/Useful.String.Extensions/
  [5]: https://github.com/IvanStoychev/Useful.String.Extensions/packages
