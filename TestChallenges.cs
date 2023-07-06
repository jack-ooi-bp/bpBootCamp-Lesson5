using Xunit;
using FluentAssertions;
using Microsoft.VisualBasic;

namespace consolidation_csharp_lesson_5
{
    public class TestChallenges
    {
        public static object[] ExpectedNumbersOver50 = new object[]
        {
            new object[] { Array.Empty<int>(), Array.Empty<int>() },
            new object[] { new int[] { 70 }, new int[] { 70 } },
            new object[] { new int[] { -10, 50, 100, -1000 }, new int[] { 100 } },
            new object[] { new int[] { 45, 67, 65, 43 }, new int[] { 67, 65 } }
        };

        [Theory]
        [MemberData(nameof(ExpectedNumbersOver50))]
        public void TestGetNumbersOver50V1(int[] input, int[] expectedOutput)
        {
            var result = Challenges.GetNumbersOver50V1(input);
            result.Should().BeEquivalentTo(expectedOutput);
        }

        [Theory]
        [MemberData(nameof(ExpectedNumbersOver50))]
        public void TestGetNumbersOver50V2(int[] input, int[] expectedOutput)
        {
            var result = Challenges.GetNumbersOver50V1(input);
            result.Should().BeEquivalentTo(expectedOutput);
        }

        public static object[] ExpectedWordsUnder5Characters = new object[]
        {
            new object[] { new string[] { }, new string[] { } },
            new object[] { new string[] { "the" }, new string[] { "the" } },
            new object[] { new string[] { "a", "nice", "banana" }, new string[] { "a", "nice" } },
            new object[]
                {
                    new string[] { "the", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog" },
                    new string[] { "the", "fox", "over", "the", "lazy", "dog" }
                }
        };

        [Theory]
        [MemberData(nameof(ExpectedWordsUnder5Characters))]
        public void TestGetWordsUnder5CharacterV1(string[] input, string[] expectedOutput)
        {
            var result = Challenges.GetWordsUnder5CharacterV1(input);
            result.Should().BeEquivalentTo(expectedOutput);
        }

        [Theory]
        [MemberData(nameof(ExpectedWordsUnder5Characters))]
        public void TestGetWordsUnder5CharacterV2(string[] input, string[] expectedOutput)
        {
            var result = Challenges.GetWordsUnder5CharacterV2(input);
            result.Should().BeEquivalentTo(expectedOutput);
        }

        public static object[] ExpectedNamesOfPeople = new object[]
        {
            new object[] { new List<People> { }, new object[] { } },
            new object[] { new List<People> { new People { Name = "Sally", Age = 24 }, }, new object[] { "Sally" } },
            new object[] {
                new List<People> {
                    new People { Name = "Sally", Age = 24 },
                    new People { Name = "Susan", Age = 30 },
                    new People { Name = "Saira", Age = 28 }
                },
                new object[] { "Sally", "Susan", "Saira" }
            },
            new object[] {
                new List<People> {
                    new People { Name = "Sally", Age = 24 },
                    new People { Name = "Susan", Age = 30 },
                },
                new object[] { "Sally", "Susan" }
            }
        };

        [Theory]
        [MemberData(nameof(ExpectedNamesOfPeople))]
        public void TestGetNamesV1(List<People> input, string[] expectedOutput)
        {
            var result = Challenges.GetNamesV1(input);
            result.Should().BeEquivalentTo(expectedOutput);
        }

        [Theory]
        [MemberData(nameof(ExpectedNamesOfPeople))]
        public void TestGetNamesV2(List<People> input, string[] expectedOutput)
        {
            var result = Challenges.GetNamesV2(input);
            result.Should().BeEquivalentTo(expectedOutput);
        }

        public static object[] ExpectedDoubledNumbers = new object[]
        {
            new object[] { new object[] { }, new object[] { } },
            new object[] { new object[] { 25 }, new object[] { 50 } },
            new object[] { new object[] { 3, 1, 6, 7 }, new object[] { 6, 2, 12, 14 } },
            new object[] { new object[] { -21, -34, 97, 0, 35, -8, 10 }, new object[] { -42, -68, 194, 0, 70, -16, 20 } }
        };

        [Theory]
        [MemberData(nameof(ExpectedDoubledNumbers))]
        public void TestDoubleNumbersV1(int[] input, int[] expectedOutput)
        {
            var result = Challenges.DoubleNumbersV1(input);
            result.Should().BeEquivalentTo(expectedOutput);
        }

        [Theory]
        [MemberData(nameof(ExpectedDoubledNumbers))]
        public void TestDoubleNumbersV2(int[] input, int[] expectedOutput)
        {
            var result = Challenges.DoubleNumbersV2(input);
            result.Should().BeEquivalentTo(expectedOutput);
        }

        public static object[] StringsToSplit = new object[] {
            new object[] {""},
            new object[] {"   "},
            new object[] {"banana"},
            new object[] {" split "},
            new object[] {"I like banana splits"},
            new object[] {"   I   am   very      spaced  out "}
        };

        [Theory]
        [MemberData(nameof(StringsToSplit))]
        public void TestStringSplit(string input)
        {
            Challenges.StringSplit(input).Should().BeEquivalentTo(Strings.Split(input));
        }

        public static object[] StringsToJoin = new object[]
        {
            new object[] { " ", new string[] {}},
            new object[] { " ", new string[] { "bananas" }},
            new object[] { " and ", new string[] { "apples", "oranges" }},
            new object[] { ", ", new string[] { "strawberries", "raspberries", "blackberries" }}
        };

        [Theory]
        [MemberData(nameof(StringsToJoin))]
        public void TestStringJoin(string separator, string[] input)
        {
            Challenges.StringJoin(separator, input).Should().Be(string.Join(separator, input));
        }

        public static object[] ListsToReverse = new object[]
        {
            new object[] { new List<double> ()},
            new object[] { new List<decimal> { 22.5m }},
            new object[] { new List<string> { "hello", "there" }},
            new object[] { new List<int> { 3, 1, 6, 7 }}
        };

        [Theory]
        [MemberData(nameof(ListsToReverse))]
        public void TestListReverse<T>(List<T> input)
        {
            var result = Challenges.ListReverse(input);
            input.Reverse();
            result.Should().BeEquivalentTo(input);
        }

        public static object[] SetsToIntersect = new object[]
        {
            new object[] { new HashSet<int>(), new HashSet<int>() },
            new object[] { new HashSet<int> { 10, 20 }, new HashSet<int> { 10, 20 } },
            new object[] { new HashSet<int> { 10, 20, 30, 40 }, new HashSet<int> { 30 } },
            new object[] { new HashSet<int> { 10, 20, 30, 40 }, new HashSet<int> { 50, 60 } }
        };

        [Theory]
        [MemberData(nameof(SetsToIntersect))]
        public void TestSetIntersection<T>(HashSet<T> items1, HashSet<T> items2)
        {
            var result = Challenges.SetIntersection(items1, items2);
            result.Should().BeEquivalentTo(new HashSet<T>(items1.Union(items2)));
        }
    }
}