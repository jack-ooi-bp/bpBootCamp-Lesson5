using System.Globalization;
using Microsoft.VisualBasic;

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

    public static string[] GetWordsUnder5CharacterV1(string[] words)
    {
        var newList = new List<string>();
        foreach (var word in words)
        {
            if (word.Length > 5)
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
        throw new NotImplementedException();
    }

    public static string[] GetNamesV2(List<People> people)
    {
        throw new NotImplementedException();
    }

    public static int[] DoubleNumbersV1(int[] numbers)
    {
        throw new NotImplementedException();
    }

    public static int[] DoubleNumbersV2(int[] numbers)
    {
        throw new NotImplementedException();
    }

    public static string[] StringSplit(string stringToSplit)
    {
        throw new NotImplementedException();
    }

    public static string StringJoin(string separator, string[] stringsToJoin)
    {
        throw new NotImplementedException();
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
