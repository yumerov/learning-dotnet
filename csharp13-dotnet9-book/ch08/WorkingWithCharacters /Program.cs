using System.Buffers;
using static System.Console;

string vowels = "AEIOUaeiou";
// .NET 8 and later.
SearchValues<char> vowelsSearchValues = SearchValues.Create(vowels);   
ReadOnlySpan<char> text = "Fred";
WriteLine($"vowels: {vowels}");
WriteLine($"text: {text}");
WriteLine($"text.IndexOfAny(vowelsSearchValues): {text.IndexOfAny(vowelsSearchValues)}");

string[] names = [ "Cassian", "Luthen", "Mon Mothma", "Dedra", "Syril", "Kino"];
// .NET 9 and later.
SearchValues<string> namesSearchValues = SearchValues.Create(names, StringComparison.OrdinalIgnoreCase);
ReadOnlySpan<char> sentence = "In Andor, Diego Luna returns as the titular character, Cassian Andor, to whom audiences were first introduced in Rogue One.";
WriteLine($"names: {string.Join(' ', names)}");
WriteLine($"sentence: {sentence}");
WriteLine($"sentence.IndexOfAny(vowelsSearchValues): {sentence.IndexOfAny(namesSearchValues)}");
