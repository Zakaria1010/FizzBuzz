using FluentAssertions;
using RomanNumerals;
using System.Collections;

namespace RomanNumeralsTests
{
    public class TestDataGenerator : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new List<object[]>
        {
            new object[] {"", 0},
            new object[] {"I", 1},
            new object[] {"II", 2},
            new object[] {"III", 3},
            new object[] {"IV", 4},
            new object[] {"V", 5},
            new object[] {"VI", 6},
            new object[] {"IX", 9},
            new object[] {"X", 10},
            new object[] {"MMXXIII", 2023},
            new object[] {"CDXLIV", 444},
            new object[] {"DCLXVI", 666},

        };
        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public class RomanNumeralTest
    {

        [Theory]
        [ClassData(typeof(TestDataGenerator))]
        public void Should_Return_RomanNumeral(string romanNumeral, int arabicNumeral)
        {
            var numeral = new RomanNumeral();
            romanNumeral.Should().Be(numeral.ToRoman(arabicNumeral));
        }
    }
}