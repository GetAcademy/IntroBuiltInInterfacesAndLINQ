// See https://aka.ms/new-console-template for more information

using IntroBuiltInInterfacesAndLINQ;

Console.WriteLine("Hello, World!");


var ints1 = new List<int>{1, 2, 3};
var ints2 = new int[]{1, 2, 3};
string text = "jkfdskj";
bool b = false;
var sequence = new DoublingNumberSequence(1, 1000);

foreach (var element in sequence)
{
    Console.WriteLine(element);
}