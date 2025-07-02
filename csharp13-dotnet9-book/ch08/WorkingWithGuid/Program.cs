using static System.Console;

WriteLine($"Empty GUID: {Guid.Empty}.");
Guid g = Guid.NewGuid();
WriteLine($"Random GUID: {g}.");
var guidAsBytes = g.ToByteArray();
Write("GUID as byte array: ");
foreach (var t in guidAsBytes)
{
    Write($"{t:X2} ");
}
WriteLine();
WriteLine("Generating three v7 GUIDs:");
for (int i = 0; i < 3; i++)
{
    Guid g7 = Guid.CreateVersion7(DateTimeOffset.UtcNow);
    WriteLine($"  {g7}.");
}