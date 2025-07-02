using static System.Console;

Random r = Random.Shared;
int dieRoll = r.Next(minValue: 1, maxValue: 7); // Returns 1 to 6.
WriteLine($"Random die roll: {dieRoll}");
double randomReal = r.NextDouble();
WriteLine($"Random double: {randomReal}");
byte[] arrayOfBytes = new byte[256];
r.NextBytes(arrayOfBytes);
Write("Random bytes: ");
foreach (var t in arrayOfBytes)
{
    Write($"{t:X2} ");
}
WriteLine();

string[] beatles = r.GetItems(
    choices: new[] { "John", "Paul", "George", "Ringo" },
    length: 10);
Write("Random ten beatles:");
foreach (string beatle in beatles)
{
    Write($" {beatle}");
}
WriteLine();
r.Shuffle(beatles);
Write("Shuffled beatles:");
foreach (string beatle in beatles)
{
    Write($" {beatle}");
}
WriteLine();