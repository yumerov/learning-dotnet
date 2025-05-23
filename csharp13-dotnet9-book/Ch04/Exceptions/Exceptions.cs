namespace Exceptions;

public static class Exceptions
{
    public static void Print(string message)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(message);
        Console.WriteLine(message);
    }

    public static void Callstack()
    {
        File.OpenText("fail.txt").Close();
    }
}