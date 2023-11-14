using Microsoft.VisualBasic;

namespace consolidation_csharp_lesson_5;
public static class Challenges
{
    public static int[] GetNumbersOver50V1(int[] numbers)
    {
        var result = numbers.Where(num => num > 50).ToArray();

        Console.WriteLine("Original numbers: " + string.Join(", ", numbers));
        Console.WriteLine("Numbers over 50: " + string.Join(", ", result));
        return result;

    }

    public static int[] GetNumbersOver50V2(int[] numbers)
    {
        IEnumerable<int> GetNumbersOver50V1(this IEnumerable<int>numbers);
        return 
        
    }

    public static string[] GetWordsUnder5CharacterV1(string[] words)
    {
        throw new NotImplementedException();
    }

    public static string[] GetWordsUnder5CharacterV2(string[] words)
    {
        throw new NotImplementedException();
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
