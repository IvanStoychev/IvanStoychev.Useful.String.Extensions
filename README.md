# Useful.String.Extensions
A .Net Core class library collection of extension methods for the "string" class in C#.

This repo uses [Semantic Versioning 2.0.0][1]

<br/>

Introduction
------------
This is a collection of extension methods that I have been in need of many a time, so I finally wrote them in a nuget package and published the code here. They are designed to be "ease-of-life" and "generally making your life easier" methods.


<br/>

Installation
------------
__Long version:__
<br/>To use the library, either download the package from NuGet by searching for "Useful.String.Extensions" or clone the repo and build in it "Release", which will create a package file in the project's release dir - "~\Useful.String.Extensions\Useful.String.Extensions\bin\Release". Then you have to install the package file in your project.

__tl;dr:__
<br/>*Install using "Package Manager Console"*
<br/>1. Run this command in the "Package Manager Console" "*Install-Package Useful.String.Extensions*".
<br/>
<br/>*Install using .NET CLI*
<br/>1. Download the project.
<br/>2. Open a command line and navigate to "<project download location>\Useful.String.Extensions\".
<br/>3. Run the command "*dotnet add package Useful.String.Extensions*".
<br/>
<br/>*Install using PackageReference*
<br/>1. Add this line, in an "*<ItemGroup>*", to your .csproj file "*<PackageReference Include="Useful.String.Extensions" Version="1.4.0" />*".
<br/>
<br/>*Install using Paket CLI*
<br/>1. Run the command "*paket add Useful.String.Extensions*".

<br/>

Documentation
-
The methods in the package and project have ample summary information, you can also consult the [Wiki][2].


  [1]: https://semver.org/#semantic-versioning-200
  [2]: https://github.com/IvanStoychev/Useful.String.Extensions/wiki/
