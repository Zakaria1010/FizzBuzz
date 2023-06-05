// See https://aka.ms/new-console-template for more information
using System.Globalization;
using OhceKataClass = OhceKata.OhceKata;

Console.WriteLine("Enter your name: ");
string name = Console.ReadLine();

DateTime time = DateTime.Now;
run(time.Hour, name);


static void run(int time, string name)
{
    OhceKataClass ohceKata = new OhceKataClass();
    var greeter = ohceKata.Greeting(time, name);
    Console.WriteLine(greeter);
    ohceKata.StopCheck(name);

}
