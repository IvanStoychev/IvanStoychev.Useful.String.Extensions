# Changelog

The changes each version of this project brings are documented here.

This file's format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/).
<br>This project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [2.0.0] - 25th April 2022

### Fixes
💜 Fixed `KeepOnlySpecialCharacters()` method only keeping a single instance of each special character.

### Additions

🟢 Updated to .Net 6.
<br>🟢 Updated NuGet Icon.
<br>🟢 Added NuGet README.
<br>🟢 Improved all method validation and thrown exception messages. Now any problems will be caught better and any exceptions caused will contain more useful information.
<br>🟢 Embedded debug symbols, so that the library source code can be stepped through during debugging.
<br>🟢 Added `Trim(string trimString, StringComparison stringComparison = StringComparison.CurrentCulture, bool trimWhitespace = false)` and `Trim(string trimString, bool ignoreCase, CultureInfo? culture, bool trimWhitespace = false)` methods that remove leading and tailing occurrences of the given `trimString`.

### Changes

🟡 Improved some summaries.
<br>🟡 Consolidated the `Replace(IEnumerable<string> oldStrings, string newString)` and `Replace(IEnumerable<string> oldStrings, string newString, bool ignoreCase)` methods into `Replace(string newString, IEnumerable<string> oldStrings, StringComparison stringComparison = StringComparison.CurrentCulture)`. This allows more string comparison flexibility and features improved validation of arguments and information in thrown exceptions.
<br>🟡 Consolidated the `Replace(IEnumerable<string> oldStrings, string newString)` and `Replace(IEnumerable<string> oldStrings, string newString, bool ignoreCase)` methods into `Replace(string newString, IEnumerable<string> oldStrings, StringComparison stringComparison = StringComparison.CurrentCulture)`. This allows more string comparison flexibility.
<br>🟡 Consolidated the `Remove(IEnumerable<string> removeStrings)` and `Remove(bool ignoreCase, IEnumerable<string> removeStrings)` methods into `Remove(IEnumerable<string> removeStrings, StringComparison stringComparison = StringComparison.CurrentCulture)`.
<br>🟡 Changed signature of method `Replace(bool ignoreCase, string newString, params string[] oldStrings)` to `Replace(string newString, bool ignoreCase = false, params string[] oldStrings)`.
<br>🟡 Added additional information in ArgumentNullExceptions about the name of the method the exception occurred in.
<br>      Before the message would be akin to "The argument given for 'keychars' was null.", now the message will be akin to "The argument given for parameter "keychars" of method "Contains" was null.".
<br>      This was done to give more details to developers trying to debug the source of such an exception, as many different methods can have parameters with the same name.
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

## [1.0.0] - 25th April 2022

Rebranded from `IvanStoychev.StringExtensions`.