using System.Text.RegularExpressions;

namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (String.IsNullOrEmpty(numbers)) return 0;

            var splitters  = new List<char> { ',', '\n' };
            

            if(numbers.StartsWith("//"))
            {
                var splitFirstLine = numbers.Split(new char[] {'\n'}, 2);
                var customDelimitor = splitFirstLine[0].Replace("//", string.Empty).Single();
                splitters.Add(customDelimitor);
                numbers = splitFirstLine[1];
            }

            string[] result = numbers.Split(splitters.ToArray());
            if(result.Length <= 1 ) return int.Parse(result[0]);

            ThrowExceptionIfAnyNegative(result);

            int sum = result.Select(x => int.Parse(x)).Where(y => y <= 1000).Sum();
            return sum;
        }

        

        public void ThrowExceptionIfAnyNegative(string [] result)
        {
            int[] negatives = result.Select(x => int.Parse(x)).Where(y => y < 0).ToArray();
            if (negatives.Length > 0)
            {
                throw new NegativeNumbersException("Negatives Numbers Not Allowed: " + String.Join(",", negatives));
            }
        }

        
        
    }
}