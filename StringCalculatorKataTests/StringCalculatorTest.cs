using FluentAssertions;
using StringCalculatorKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorKataTests
{
    public class StringCalculatorTest
    {

        private StringCalculator stringCalculator;
        public StringCalculatorTest() 
        { 
            stringCalculator = new StringCalculator();
        }


        [Fact]
        public void Should_Returns_Sum_Of_Comma_Seperated_Numbers()
        {
            string example = "1,2";
            int expected = 3;
            int actual = stringCalculator.Add(example);
            actual.Should().Be(expected);
        }

        [Fact]
        public void Empty_String_Should_Returns_0()
        {
            string example = "";
            int expected = 0;
            int actual = stringCalculator.Add(example);
            actual.Should().Be(expected);
        }

        [Fact]
        public void One_String_Number_Should_Returns_The_Number()
        {
            string example = "1";
            int expected = 1;
            int actual = stringCalculator.Add(example);
            actual.Should().Be(expected);
        }

        [Fact]
        public void Should_Handle_New_Lines_Between_Numbers()
        {
            string example = "1\n2,3";
            int expected = 6;
            int actual = stringCalculator.Add(example);
            actual.Should().Be(expected);
        }

        [Fact]
        public void Should_Throw_Exception_For_Negative_Numbers()
        {
            string example = "1,-2,-5,-8";
            string expected = "-2,-5,-8";
            Action  execute = ()  => stringCalculator.Add(example);

            execute.Should().Throw<NegativeNumbersException>().WithMessage($"Negatives Numbers Not Allowed: {expected}");

        }
        [Theory]
        [InlineData("2,1001", 2)]
        public void Numbers_Bigger_Than_1000_Should_Be_Ignored(string calculation, int expected)
        {
            int actual = stringCalculator.Add(calculation);
            actual.Should().Be(expected);
        }

        [Theory]
        [InlineData("//;\n1;2", 3)]
        public void Should_Support_Different_Delimiters(string calculation, int expected)
        {
            int actual = stringCalculator.Add(calculation);
            actual.Should().Be(expected);
        }
        [Theory]
        [InlineData("1,2,-1", "-1")]
        [InlineData("//;\n-2\n-4", "-2,-4")]
        public void Should_Throw_Exception_For_Negative_Numbers_Multi_Tests(string calculation, string expected)
        {          
            Action execute = () => stringCalculator.Add(calculation);
            execute.Should().Throw<NegativeNumbersException>().WithMessage($"Negatives Numbers Not Allowed: {expected}");

        }

        [Theory]
        [InlineData("", 0)]
        [InlineData("1", 1)]
        [InlineData("10\n20,30\n40,50", 150)]
        [InlineData("//;\n1;2;4", 7)]
        [InlineData("//;\n2\n4", 6)]
        public void Add_AddsNumbersUsingCustomDelimiter_WhenStringIsValid(string calculation, int expected)
        {
            int actual = stringCalculator.Add(calculation);
            actual.Should().Be(expected);
        }
    }
}
