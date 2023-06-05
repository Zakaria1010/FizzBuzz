namespace RomanNumerals
{
    public class RomanNumeral
    {
        Dictionary<int, string> arabicToRoman = new Dictionary<int, string>
        {
            { 1000, "M" },
            { 900, "CM" },
            { 500, "D" },
            { 400, "CD" },
            { 100, "C" },
            { 90, "XC" },
            { 50, "L" },
            { 40, "XL" },
            { 10, "X" },
            { 9, "IX" },
            { 6, "VI" },
            { 5, "V" },
            { 4, "IV" },
            { 1, "I" }
        };
        public string ToRoman(int arabicNumber)
        {
            string roman = string.Empty;
            foreach (var key in arabicToRoman.Keys)
            {   var value = arabicToRoman[key];
                while(arabicNumber >= key)
                {
                    roman += value;
                    arabicNumber -= key;
                }
            }
            return roman;
        }
    }
}