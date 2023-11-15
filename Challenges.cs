using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using FluentAssertions;
using Microsoft.VisualBasic;
using Xunit.Sdk;

namespace consolidation_csharp_lesson_5;

public static class Challenges
{
    public static int[] GetNumbersOver50V1(int[] numbers)
    {
        var newList = new List<int>();
        foreach (var num in numbers)
        {
            if (num > 50)
            {
                newList.Add(num);
            }
        }
        return newList.ToArray();
    }

    public static int[] GetNumbersOver50V2(int[] numbers)
    {
        return numbers.Where(nums => nums > 50).ToArray<int>();
    }

    //Stil got issue with the unit test, need to check again the logic
    public static string[] GetWordsUnder5CharacterV1(string[] words)
    {
        var newList = new List<string>();
        foreach (var word in words)
        {
            if (word.Length < 5)
            {
                newList.Add(word);
            }
        }
        return newList.ToArray();
    }

    public static string[] GetWordsUnder5CharacterV2(string[] words)
    {
        var wordArray = words.Where(word => word.Length < 5).ToArray();
        return wordArray;
    }

    public static string[] GetNamesV1(List<People> people)
    {
        if (people == null)
        {
            throw new ArgumentNullException(nameof(people));
        }

        var namesArray = new List<string>();

        foreach (var person in people)
        {
            namesArray.Add(person.Name);
        }

        return namesArray.ToArray();
    }

    public static string[] GetNamesV2(List<People> people)
    {
        var namesArray = people.Select(person => person?.Name).ToArray();
        return namesArray;
    }

    public static int[] DoubleNumbersV1(int[] numbers)
    {
        if (numbers == null)
        {
            throw new ArgumentNullException(nameof(numbers));
        }

        var doubleArray = new List<int>();
        foreach (var number in numbers)
        {
            doubleArray.Add(number * 2);
        }
        return doubleArray.ToArray();
    }

    public static int[] DoubleNumbersV2(int[] numbers)
    {
        int[] doubleArray = numbers.Select(number => number * 2).ToArray();
        return doubleArray;
    }

    public static string[] StringSplit(string stringToSplit)
    {
        // if (stringToSplit == null)
        // {
        //     throw new ArgumentNullException(nameof(stringToSplit));
        // }

        var substrings = new List<string>();
        var startIndex = 0;

        while (startIndex <= substrings.Count)
        {
            var spaceIndex = stringToSplit.IndexOf(' ', startIndex);

            if (spaceIndex == -1)
            {
                spaceIndex = stringToSplit.Length;
            }

            var word = stringToSplit.Substring(startIndex, spaceIndex - startIndex);

            substrings.Add(word);

            startIndex = spaceIndex + 1;
        }
        return substrings.ToArray();
    }

    public static string StringJoin(string separator, string[] stringsToJoin)
    {
        throw new NotImplementedException();
        // if (stringsToJoin == null)
        // {
        //     throw new ArgumentNullException(nameof(stringsToJoin));
        // }

        // var substrings = new List<string>();
        // int startIndex = 0;

        // while (startIndex < substrings.Count)
        // {

        // }
    }

    public static List<T> ListReverse<T>(List<T> list)
    {
        throw new NotImplementedException();
    }

    public static HashSet<T> SetIntersection<T>(HashSet<T> items1, HashSet<T> items2)
    {
        throw new NotImplementedException();
    }
}
