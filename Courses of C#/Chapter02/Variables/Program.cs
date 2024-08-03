using System.Xml; // To use XmlDocument.

Console.WriteLine($"default(int) = {default(int)}");
Console.WriteLine($"default(int) = {default(bool)}");
Console.WriteLine($"default(DateTime) = {default(DateTime)}");
Console.WriteLine($"default(string) = {default(string)}");

int number = 13;
Console.WriteLine($"number set to: {number}");
number = default;
Console.WriteLine($"number reset to its default: {number}");

Console.Write("D");
Console.Write("I");
Console.Write("M");
Console.Write("A");
Console.Write("L");