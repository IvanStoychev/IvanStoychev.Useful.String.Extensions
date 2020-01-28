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
<br/>To use the library, either download the package from NuGet by searching for "Useful.String.Extensions" or clone the repo and build in it "Release", which will create a package file in the project's release dir - `~\Useful.String.Extensions\Useful.String.Extensions\bin\Release`. Then you have to install the package file in your project.

__tl;dr:__
<br/>Install using "Package Manager Console"
<br/>`Install-Package Useful.String.Extensions -Version 1.1.1`
<br/>
<br/>Install using .NET CLI
<br/>`dotnet add package Useful.String.Extensions --version 1.1.1`
<br/>
<br/>Install PackageReference
<br/>`<PackageReference Include="Useful.String.Extensions" Version="1.1.1" />`
<br/>
<br/>Install Paket CLI
<br/>`paket add Useful.String.Extensions --version 1.1.1`

<br/>

Documentation
-
The methods in the package and project have ample summary information, you can also consult the [Wiki][2].


  [1]: https://semver.org/#semantic-versioning-200
  [2]: https://github.com/IvanStoychev/Useful.String.Extensions/wiki/
