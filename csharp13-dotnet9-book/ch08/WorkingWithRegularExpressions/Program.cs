using System.Text.RegularExpressions;
using static System.Console;

Write("Enter your age: ");
string input = ReadLine()!;
Regex ageChecker = new(@"^\d+$");
WriteLine(ageChecker.IsMatch(input) ? "Thank you!" : $"This is not a valid age: {input}");
