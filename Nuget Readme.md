**Source link enabled**
Makes work with strings a breeze.

To get started you need only add `using IvanStoychev.Useful.String.Extensions;`

To use the library, call methods on the `string` class.

For example:

#### Remove all occurrences of a collection of strings
    string testString = "To buy: eggs, eggs, jam, ham, milk, ham, bread, bread";
    List<string> stringsToRemove = new() { "eggs, ", "ham, ", ", bread" };
    string output = testString.Remove(stringsToRemove);
    Console.WriteLine(output);
    
    // Output is "To buy: jam, milk"

#### Replace all occurrences of a collection of strings with another string
    string testString = "Gold, gems, jewels, trinkets, more gems, more jewels!";
    List<string> oldStrings = new() { "gems", "jewels", "trinkets" };
    string output = testString.Replace(oldStrings, "gold");
    Console.WriteLine(output);
    
    // Output is "Gold, gold, gold, gold, more gold, more gold!"

#### Select everything between two substrings
    string testString = "We start on Monday and we finish on Tuesday.";
    string startString = "start on ";
    string endString = " and we finish";
    string output = testString.Substring(startString, endString);
    Console.WriteLine(output);
    
    // Output is "Monday"

#### Select everything after/before a substring
    string testString = "In the beginning there was bread. In the end there was jam.";
    string startString = "bread. ";
    string endString = " In the end";
    string outputStart = testString.SubstringStart(endString);
    string outputEnd = testString.SubstringEnd(startString);
    Console.WriteLine(outputStart);
    Console.WriteLine(outputEnd);
    
    // Outputs are:
    // "In the beginning there was bread."
    // "In the end there was jam.""

All methods have a detailed summary.
For a complete list of all methods in the library and details on them consult the [wiki](https://github.com/IvanStoychev/IvanStoychev.Useful.String.Extensions/wiki).

Feel free to submit any issues or bugs to the project's [GitHub issues page](https://github.com/IvanStoychev/IvanStoychev.Useful.String.Extensions/issues).
You are welcome to follow [my projects twitter](https://twitter.com/ivan_stoychev).
[![Follow @ivan_stoychev](https://img.shields.io/twitter/url?label=Follow%20%40ivan_stoychev&style=social&url=https%3A%2F%2Ftwitter.com%2Fintent%2Ffollow%3Fscreen_name%3Divan_stoychev)](https://twitter.com/intent/follow?screen_name=ivan_stoychev)