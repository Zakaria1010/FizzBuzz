using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OhceKata
{
    public class OhceKata
    {

        public OhceKata() { 
            
        }

        public string Greeting(int time, string name)
        {
            string greet = time switch
            {
                (<= 24 and >= 20) or (>= 0 and < 6) => $"¡Buenas noches {name}!",
                >= 6 and < 12 => $"¡Buenas dias {name}!",
                >= 12 and < 20 => $"¡Buenas tardes {name}!",
                _ => ""
            };
            return greet;
        }

        public string PalindromeCheck(string word)
        {
            string reverse =  new String(word.Reverse().ToArray());
            string checkSentence = !word.Equals(reverse) ? reverse : "¡Bonita palabra!";
            return checkSentence;
        }

        public string StopCheck(string name)
        {
            
            string result = "";

            while (true)
            {
                string word = Console.ReadLine();
                if (!word.Equals("Stop!"))
                {
                    result = PalindromeCheck(word);
                    Console.WriteLine(result);
                }
                else
                {
                    result = "Adios " + name;
                    Console.WriteLine(result);
                    break;
                }

            }
            return result;
        }

    }
}
