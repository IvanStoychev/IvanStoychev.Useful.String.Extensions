![Project logo](https://user-images.githubusercontent.com/30086277/167206693-157df6ee-55f8-4f00-a32f-7d6cef52ed9b.png)

### **Source and debug symbols embedded**
#### *(You can step through this package's code during debug)*

---

### What is this?

A library of extension methods for the `string` class that make work with text easier.

### How do I get started?

Add `using IvanStoychev.Useful.String.Extensions;`
And call methods on any string.

---

### Video Demonstration
#### *(Must click to watch on YouTube)*

...

### Examples:

#### Remove all occurrences of a collection of strings
    string testString = "To buy: Eggs. eggs. Jam. Ham. Milk. ham. Bread. Bread";
    List<string> stringsToRemove = new() { "Eggs. ", "Ham. ", ". Bread" };
    string outputDefault = testString.Remove(stringsToRemove);
    string outputIgnoreCase = testString.Remove(stringsToRemove, StringComparison.InvariantCultureIgnoreCase);
    Console.WriteLine(outputDefault);
    Console.WriteLine(outputIgnoreCase);
    
    // Result
    // ------
    // outputDefault    = "To buy: eggs. Jam. Milk. ham"
    // outputIgnoreCase = "To buy: Jam. Milk"

.

#### Replace all occurrences of a collection of strings with another string
    string testString = "Gold. Gems. Jewels. Trinkets. More gems. More jewels!";
    List<string> oldStrings = new() { "Gems", "Jewels", "Trinkets" };
    string outputDefault = testString.Replace("gold", oldStrings);
    string outputIgnoreCase = testString.Replace("gold", oldStrings, StringComparison.InvariantCultureIgnoreCase);
    Console.WriteLine(outputDefault);
    Console.WriteLine(outputIgnoreCase);
    
    // Result
    // ------
    // outputDefault    = "Gold. gold. gold. gold. More gems. More jewels!"
    // outputIgnoreCase = "Gold. gold. gold. gold. More gold. More gold!"

.

#### Select everything between two substrings
    string testString = "We start on Monday and we finish on Tuesday.";
    string startString = "start on ";
    string endString = " and we finish";
    string outputDefault = testString.Substring(startString, endString);
    string outputFull = testString.Substring(startString, endString, StringInclusionOptions.IncludeAll);
    Console.WriteLine(outputDefault);
    Console.WriteLine(outputFull);
    
    // Result
    // ------
    // outputDefault = "Monday"
    // outputFull    = "start on Monday and we finish"

.

#### Select everything after/before a substring
    string testString = "In the beginning there was bread. In the end there was jam.";
    string startString = "bread. ";
    string endString = " In the end";
    string outputStart = testString.SubstringStart(endString);
    string outputEnd = testString.SubstringEnd(startString);
    Console.WriteLine(outputStart);
    Console.WriteLine(outputEnd);
    
    // Result
    // ------
    // outputStart = "In the beginning there was bread."
    // outputEnd   = "In the end there was jam."
.

All methods have a detailed summary.
For a complete list of all methods in the library and details on them consult the [wiki](https://github.com/IvanStoychev/IvanStoychev.Useful.String.Extensions/wiki).

Feel free to submit any issues or bugs to the project's [GitHub issues page](https://github.com/IvanStoychev/IvanStoychev.Useful.String.Extensions/issues).
You are welcome to follow [my projects twitter](https://twitter.com/ivan_stoychev).
[![Follow @ivan_stoychev](https://img.shields.io/twitter/url?label=Follow%20%40ivan_stoychev&style=social&url=https%3A%2F%2Ftwitter.com%2Fintent%2Ffollow%3Fscreen_name%3Divan_stoychev)](https://twitter.com/intent/follow?screen_name=ivan_stoychev)