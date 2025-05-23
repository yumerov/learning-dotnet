try
{
    Exceptions.Exceptions.Print("");
}
catch (ArgumentException exception)
{
    Console.WriteLine($"Error: {exception.Message}");
}

Exceptions.Exceptions.Callstack();