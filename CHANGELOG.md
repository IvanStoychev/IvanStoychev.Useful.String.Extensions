# Changelog

The changes each version of this project brings are documented here.

This project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).


Legend:
<br>💜 - Bug fix
<br>🟢 - New feature
<br>🔴 - Removed feature
<br>🟡 - Altered existing feature
<br>⚪ - Note not directly relating to the project functionality

---

## [[6.0.0] - xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx Date xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx](https://github.com/IvanStoychev/IvanStoychev.Useful.String.Extensions/releases/tag/6.0.0)

💜 Removed the summaries that remained from the old class names.

🟢 Added "StringExtensions.cs" file which holds the class summary.

🟢 Added additional validation checks for `enum` arguments. If the user passes an invalid argument to an `enum` parameter an `ArgumentException` will be thrown, alerting him which argument, passed to what parameter in which method is invalid.

🟢 Added new validation check whether the string on which any method is called is `null`.

🟢 Added the following methods:
- Contains.cs - `ContainsAll`
- Remove.cs - `Remove` overloads that take `char` collections and/or `CultureInfo?` parameters.
- Replace.cs - `Replace` overloads that take `char` collections for old values, `char` argument for the new value, `KeyValuePair` collections for old and new values and `CultureInfo?` instead of `StringComparison`.
- ExceptionThrower.cs - `Throw_ArgumentException_EnumValueInvalid`
- Validate.cs - `EnumContainsValue`

🟡 Changed the following method signatures:

`Replace(this string str, string newString, IEnumerable<string> oldStrings, StringComparison comparison = StringComparison.CurrentCulture)`
changed to
`Replace(this string str, IEnumerable<string> oldStrings, string? newString, StringComparison comparison = StringComparison.CurrentCulture)`
this change was made to adhere to the signature of standard .Net `Replace` methods. The old signature was a remnant of times long past, when the purpose was to allow the user to pass an arbitraty amount of strings via a last `params string[]` parameter, which evolved into an `IEnumerable<string>` parameter. When that evolution happened a reordering of the parameters didn't occur to me.

🟡 Renamed the following files:
- <ins>Comparer.cs</ins> to "*Contains.cs*"
- <ins>Keeper.cs</ins> to "*Keep.cs*"
- <ins>Remover.cs</ins> to "*Remove.cs*"
- <ins>Selector.cs</ins> to "*Substring.cs*"
- <ins>Replacer.cs</ins> to "*Replace.cs*"
- <ins>Comparer_Tests.cs</ins> to "*Contains_Tests.cs*"
- <ins>Remover_Tests.cs</ins> to "*Remove_Tests.cs*"
- <ins>Selector_Tests.cs</ins> to "*Substring_Tests.cs*"
- <ins>Replacer_Tests.cs</ins> to "*Replace_Tests.cs*"
- <ins>Comparer_Tests_Exceptions.cs</ins> to "*Contains_Tests_Exceptions.cs*"
- <ins>Remover_Tests_Exceptions.cs</ins> to "*Remove_Tests_Exceptions.cs*"
- <ins>Selector_Tests_Exceptions.cs</ins> to "*Substring_Tests_Exceptions.cs*"
- <ins>Replacer_Tests_Exceptions.cs</ins> to "*Replace_Tests_Exceptions.cs*"

🟡 Renamed the following methods:

`ExceptionThrower.cs`
- <ins>Throw_ArgumentNullMemberException</ins> to "*Throw_ArgumentNullException_CollectionMember*"

`Validator.cs`
- <ins>EmptyString</ins> to "*NotEmptyString*"
- <ins>NullArgument</ins> to "*NotNull*"
- <ins>NullMember</ins> to "*NotNullMember*"

`Contains.cs`
- <ins>Contains</ins> to "*ContainsAny*"

🟡 Made `Validator.cs` - `IEnumNotEmpty` method generic.

🟡 Made `Validator.cs` - `SubstringIndex` method private.

🟡 Added "Trim.cs" file and moved "Trim", "TrimEnd" and "TrimStart" methods into it from the old "Remover.cs".

⚪ Updated all tests.

## [[5.0.1] - 19 APR 2025](https://github.com/IvanStoychev/IvanStoychev.Useful.String.Extensions/releases/tag/5.0.1)

💜 Sanitized exception messages to not include potentially sensitive data, restructure exception messages a bit to be more readable, update method signatures and summaries.

⚪ Renamed "StringExtensions" classes to "UsefulStringExtensions", as the previous name was too generic and could cause conflicts with user code or other libraries.
<br>⚪ Changed the CHANGELOG date format.

## [[5.0.0] - 02 DEC 2023](https://github.com/IvanStoychev/IvanStoychev.Useful.String.Extensions/releases/tag/5.0.0)

💜 Fixed some test names, test data and added missing tests for "TrimStart" and "TrimEnd" methods.

🟢 Updated library to .Net 8.

🟡 Changed library class structure to additionally facilitate users. Now all classes are partial and named "StringExtensions" to allow users to have their own classes using the old class names. File names remain unchanged for ease of structural navigation.

## [[4.0.0] - 17 MAR 2023](https://github.com/IvanStoychev/IvanStoychev.Useful.String.Extensions/releases/tag/4.0.0)

🟢 Updated to .Net 7

⚪ Inconsequently, from this point onwards changelog sections names (such as "Changes", "Fixes", etc.) will be omitted, as there is a visual legend present.

## [[3.0.0] - 10 OCT 2022](https://github.com/IvanStoychev/IvanStoychev.Useful.String.Extensions/releases/tag/3.0.0)

### Changes

🟡 All "Trim", "TrimStart" and "TrimEnd" methods now remove all leading/trailing occurrences of the given string, instead of just the first, as this is more in line with the existing .NET methods.
<br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;While this could more be regarded as a "bug fix" it significantly changes the way those methods work and, thus, this is a new major version release.

## [[2.0.1] - 27 JUN 2022](https://github.com/IvanStoychev/IvanStoychev.Useful.String.Extensions/releases/tag/2.0.1)

### Fixes
💜 Fixed debug symbols not being embedded in the package.

## [[2.0.0] - 26 JUN 2022](https://github.com/IvanStoychev/IvanStoychev.Useful.String.Extensions/releases/tag/2.0.0)

### Fixes
💜 Fixed `KeepOnlySpecialCharacters()` method only keeping a single instance of each special character.

### Additions

🟢 Updated to .Net 6.
<br>🟢 Updated NuGet Icon.
<br>🟢 Added NuGet README.
<br>🟢 Improved all method validation and thrown exception messages. Now any problems will be caught better and any exceptions caused will contain more useful information.
<br>🟢 Embedded debug symbols, so that the library source code can be stepped through during debugging.
<br>🟢 Added `Remove(string removeString, StringComparison stringComparison = StringComparison.CurrentCulture)` method that removes all occurrences of the given `removeString`.
<br>🟢 Added `Trim(string trimString, StringComparison stringComparison = StringComparison.CurrentCulture, bool trimWhitespace = false)` and `Trim(string trimString, bool ignoreCase, CultureInfo? culture, bool trimWhitespace = false)` methods that remove leading and tailing occurrences of the given `trimString`.

### Changes

🟡 Improved some summaries.
<br>🟡 Consolidated the `Replace(IEnumerable<string> oldStrings, string newString)` and `Replace(IEnumerable<string> oldStrings, string newString, bool ignoreCase)` methods into `Replace(string newString, IEnumerable<string> oldStrings, StringComparison stringComparison = StringComparison.CurrentCulture)`. This allows more string comparison flexibility and features improved validation of arguments and information in thrown exceptions.
<br>🟡 Consolidated the `Replace(IEnumerable<string> oldStrings, string newString)` and `Replace(IEnumerable<string> oldStrings, string newString, bool ignoreCase)` methods into `Replace(string newString, IEnumerable<string> oldStrings, StringComparison stringComparison = StringComparison.CurrentCulture)`. This allows more string comparison flexibility.
<br>🟡 Consolidated the `Remove(IEnumerable<string> removeStrings)` and `Remove(bool ignoreCase, IEnumerable<string> removeStrings)` methods into `Remove(IEnumerable<string> removeStrings, StringComparison stringComparison = StringComparison.CurrentCulture)`.
<br>🟡 Changed signature of method `Replace(bool ignoreCase, string newString, params string[] oldStrings)` to `Replace(string newString, bool ignoreCase = false, params string[] oldStrings)`.
<br>🟡 Added additional information in ArgumentNullExceptions about the name of the method the exception occurred in.
<br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Before the message would be akin to "The argument given for 'keychars' was null.", now the message will be akin to "The argument given for parameter "keychars" of method "Contains" was null.".
<br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;This was done to give more details to developers trying to debug the source of such an exception, as many different methods can have parameters with the same name.
<br>🟡 Added boolean "trimWhitespace" parameter and changed parameter "culture" of methods `TrimStart(string trimString, bool ignoreCase, CultureInfo culture)` and `TrimEnd(string trimString, bool ignoreCase, CultureInfo culture)` to be nullable. The signatures are now `TrimStart(string trimString, bool ignoreCase, CultureInfo? culture, bool trimWhitespace = false)` and `TrimEnd(string trimString, bool ignoreCase, CultureInfo? culture, bool trimWhitespace = false)`.

### Removals

##### Methods:

🔴 `Replace(string newString, params string[] oldStrings)`
<br>🔴 `Replace(bool ignoreCase, string newString, params string[] oldStrings)`
<br>🔴 `Contains(params string[] keywords)`
<br>🔴 `Contains(StringComparison comparison, params string[] keywords)`
<br>🔴 `Contains(params char[] keychars)`
<br>🔴 `Contains(StringComparison comparison, params char[] keychars)`
<br>🔴 `Remove(params string[] removeStrings)`
<br>🔴 `Remove(bool ignoreCase, params string[] removeStrings)`

These methods could be legally called with no argument for the `params` parameter, which would either do nothing or throw an exception. This is a very confusing and unpleasant behaviour, even when fully documented.
It was decided that the convenience of, potentially, saving the user from passing these arguments as an `IEnumerable` is not worth the hassle.

🔴 `Trim(int amount)`
<br>🔴 `TrimStart(int amount)`
<br>🔴 `TrimEnd(int amount)`

These methods' functionality can be easily achieved with [indices and ranges](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/tutorials/ranges-indexes) or the "Substring" method.

🔴 `TrimStart(string trimString)`
<br>🔴 `TrimEnd(string trimString)`

Added default value for parameter `stringComparison` of methods `TrimStart(string trimString, StringComparison stringComparison)` and `TrimEnd(string trimString, StringComparison stringComparison)`, thus the same functionality can be achieved with them.

## [[1.0.0] - 14 JUN 2021](https://github.com/IvanStoychev/IvanStoychev.Useful.String.Extensions/releases/tag/1.0.0)

Rebranded from `IvanStoychev.StringExtensions`.
