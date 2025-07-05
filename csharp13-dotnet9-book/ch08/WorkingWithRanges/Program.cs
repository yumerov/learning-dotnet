using static System.Console;

const string name = "Samantha Jones";
int lengthOfFirst = name.IndexOf(' ');
int lengthOfLast = name.Length - lengthOfFirst - 1;
string firstName = name.Substring(startIndex: 0, length: lengthOfFirst);
string lastName = name.Substring(startIndex: name.Length - lengthOfLast, length: lengthOfLast);
WriteLine($"First: {firstName}, Last: {lastName}");

ReadOnlySpan<char> nameAsSpan = name.AsSpan();
ReadOnlySpan<char> firstNameSpan = nameAsSpan[..lengthOfFirst];
ReadOnlySpan<char> lastNameSpan = nameAsSpan[^lengthOfLast..];
WriteLine($"First: {firstNameSpan}, Last: {lastNameSpan}");

ReadOnlySpan<char> text = "12+23+456".AsSpan();
int sum = 0;
foreach (Range r in text.Split('+'))
{
    sum += int.Parse(text[r]);
}
WriteLine($"Sum using Split: {sum}");
