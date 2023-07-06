# Lesson 5 Independent Challenges

## Challenge 1: `GetNumbersOver50V1` (8 points)

| Method parameter(s)        | Method return(s)                                                |
|------------------------------|-------------------------------------------------------------------|
| `numbers`, an array of numbers | An array of only those numbers from the input list that are over 50 |

Write a method that takes an array of numbers and returns an array of the numbers from the original list that are over 50.

**Important note:** for version 1 of this method, you should **NOT** use `IEnumerable<T>` extension methods. Your reviewers will check this.

## Challenge 2: `GetNumbersOver50V2` (8 points)

Same as previous challenge, but this time you must use `IEnumerable<T>` extension methods. Your reviewers will check this.

## Challenge 3: `GetWordsUnder5CharacterV1` (8 points)

| Method parameter(s)      | Method return(s)                                                              |
|----------------------------|---------------------------------------------------------------------------------|
| `words`, an array of strings | An array of only those words from the input list that are under 5 characters long |

Write a method that takes an array of words and returns an array of the numbers from the original list that are under 5 characters long.

**Important note:** for version 1 of this method, you should **NOT** use `IEnumerable<T>` extension methods. Your reviewers will check this.

## Challenge 4: `GetWordsUnder5CharacterV2` (8 points)

Same as previous challenge, but this time you must use `IEnumerable<T>` extension methods. Your reviewers will check this.

## Challenge 5: `GetNamesV1` (8 points)

| Method parameter(s)                                | Method return(s)                                    |
|------------------------------------------------------|-------------------------------------------------------|
| `people`, a list of people | An array of the names of the people from the input list |

Write a method that takes an array of People class and returns an array of the `'name'` strings from each class in the original list.

**Important note:** for version 1 of this method, you should **NOT** use `IEnumerable<T>` extension methods. Your reviewers will check this.

## Challenge 6: `GetNamesV2` (8 points)

Same as previous challenge, but this time you must use `IEnumerable<T>` extension methods. Your reviewers will check this.

## Challenge 7: `DoubleNumbersV1` (8 points)

| Method parameter(s)        | Method return(s)                                |
|------------------------------|---------------------------------------------------|
| `numbers`, an array of numbers | A array of each number from the input array doubled |

Write a method that takes an array of numbers and returns an array of the numbers from the original array doubled.

**Important note:** for version 1 of this method, you should **NOT** use `IEnumerable<T>` extension methods. Your reviewers will check this.

## Challenge 8: `DoubleNumbersV2` (8 points)

Same as previous challenge, but this time you must use `IEnumerable<T>` extension methods. Your reviewers will check this.

## Challenge 9: `StringSplit` (12 points)

| Method parameter(s)                | Method return(s)                         |
|--------------------------------------|--------------------------------------------|
| `stringToSplit`, a string to split | An array of individual words from the string |

Write a method that takes a string and separates it into an array of substrings based on the position of the space characters in the original. For example, the string `"One two three"` should be separated into the list of words `{"One", "two", "three"}`.

**Important note:** if you are in any doubt as to the intended behaviour of the method, note that it should mimic the behaviour of the built-in `string.Split` method. You should not use this method as part of your solution. Your reviewers will check this.

## Challenge 10: `StringJoin` (8 points)

| Method parameter(s)                                                                                | Method return(s)                                                                             |
|------------------------------------------------------------------------------------------------------|------------------------------------------------------------------------------------------------|
| `separator`, a string to use to separate each string in `stringsToJoin`, an array of strings to join | A string containing all the strings in the list of strings to join, separated by the separator |

Write a method that takes a separator string and an array of strings to join, and combines them to form a single string containing each of the strings to join, separated by the separator. For example, the separator string `' AND '` and the list of strings to join `{"one", "two", "three"}` should join to form the string `"one AND two AND three"`.

**Important note:** if you are in any doubt as to the intended behaviour of the method, note that it should mimic the behaviour of the built-in `string.Join` method. You should not use this method as part of your solution. Your reviewers will check this.

## Challenge 11: `ListReverse` (8 points)

| Method parameter(s)    | Method return(s)                          |
|--------------------------|---------------------------------------------|
| `items`, a list of items | A list containing the same items in reverse |

Write a method that takes a list of items and returns another list containing the same items in reverse.

**Important note:** you should not use the inbuilt `Reverse` extension method method as part of your solution. Your reviewers will check this.

## Challenge 12: `SetIntersection` (8 points)

| Method parameter(s)                      | Method return(s)                                      |
|--------------------------------------------|---------------------------------------------------------|
| `items1` and `items2`, two sets of items | A set containing the overlap between the two input sets |

Write a method that takes two sets of items and returns another set containing only those items that belong to both of the original sets.

**Important note:** you should not use the inbuilt `Union` extension method as part of your solution. Your reviewers will check this.
