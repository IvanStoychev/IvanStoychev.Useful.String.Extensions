# Changelog

The changes each version of this project brings are documented here.

This file's format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/).
<br>This project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).


Legend:
<br>💜 - Bug fix
<br>🟢 - New feature
<br>🔴 - Removed feature
<br>🟡 - Altered existing feature
<br>⚪ - Note not directly relating to the project functionality

---

## [5.0.1] - 19 APR 2025

💜 Sanitized exception messages to not include potentially sensitive data, restructure exception messages a bit to be more readable, update method signatures and summaries.

⚪ Renamed "StringExtensions" classes to "UsefulStringExtensions", as the previous name was too generic and could cause conflicts with user code or other libraries.
<br>⚪ Changed the CHANGELOG date format.

## [5.0.0] - 02 DEC 2023

💜 Fixed some test names, test data and added missing tests for "TrimStart" and "TrimEnd" methods.
🟢 Updated library to .Net 8.

🟡 Changed library class structure to additionally facilitate users. Now all classes are partial and named "StringExtensions" to allow users to have their own classes using the old class names. File names remain unchanged for ease of structural navigation.

## [4.0.0] - 17 MAR 2023

🟢 Updated to .Net 7

⚪ Inconsequently, from this point onwards changelog sections names (such as "Changes", "Fixes", etc.) will be omitted, as there is a visual legend present.

## [3.0.0] - 10 OCT 2022

### Changes

🟡 All "Trim", "TrimStart" and "TrimEnd" methods now remove all leading/trailing occurrences of the given string, instead of just the first, as this is more in line with the existing .NET methods.
<br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;While this could more be regarded as a "bug fix" it significantly changes the way those methods work and, thus, this is a new major version release.

## [2.0.1] - 27 JUN 2022

### Fixes
💜 Fixed debug symbols not being embedded in the package.

## [2.0.0] - 26 JUN 2022

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

## [1.0.0] - 14 JUN 2021

Rebranded from `IvanStoychev.StringExtensions`.
