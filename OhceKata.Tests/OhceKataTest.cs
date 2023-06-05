using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OhceKata.Tests
{
    public class OhceKataTest
    {
        
        private OhceKata kata;

        public OhceKataTest()
        {
            kata = new OhceKata();
        }

        [Fact]
        public void Should_Greet_Buenas_Noches()
        {
            var name = "name";
            TimeSpan time = TimeSpan.FromHours(21);
            string expected = $"¡Buenas noches {name}!";
            string actual = kata.Greeting(time.Hours, name);
            actual.Should().Be(expected);
        }

        [Fact]
        public void Should_Greet_Buenas_dias()
        {
            var name = "name";
            TimeSpan time = TimeSpan.FromHours(7);
            string expected = $"¡Buenas dias {name}!";
            string actual = kata.Greeting(time.Hours, name);
            actual.Should().Be(expected);
        }
        
        [Fact]
        public void Should_Greet_Buenas_tardes()
        {
            var name = "name";
            TimeSpan time = TimeSpan.FromHours(13);
            string expected = $"¡Buenas tardes {name}!";
            string actual = kata.Greeting(time.Hours, name);
            actual.Should().Be(expected);
        }

        [Fact]  
        public void Should_Throw_Bonita_Palabra_If_Palindrome()
        {
            string word = "oto";
            string expected = "¡Bonita palabra!";

            string actual = kata.PalindromeCheck(word);
            
            actual.Should().Be(expected);
        }

        [Fact]
        public void Should_Be_Case_Sensitive_When_Typing_Stop()
        {
            string stop = "stop";
            string expected = "pots";

            string actual = kata.PalindromeCheck(stop);

            actual.Should().Be(expected);
        }

        [Fact]
        public void Should_Be_Case_Sensitive_When_Typing_Stop()
        {
            string stop = "stop";
            string expected = "pots";

            string actual = kata.StopCheck(stop);

            actual.Should().Be(expected);
        } 

        [Fact]
        public void Should_Answer_Adios_When_Stop()
        {
            string name = "Zaka!";
            string expected = $"Adios {name}";
            var input = new StringReader("Stop!");
            Console.SetIn(input);

            string actual = kata.StopCheck(name);

            actual.Should().Be(expected);
        }

    }
}
