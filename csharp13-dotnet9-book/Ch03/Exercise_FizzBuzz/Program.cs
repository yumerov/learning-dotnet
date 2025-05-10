using static System.Console;

const int fizzDenominator = 3;
const int buzzDenominator = 5;
const int total = 100;
const int perLine = 10;

for (int index = 1; index <= total; index++)
{
    bool alreadyFizzBuzz = false;
    if (index % fizzDenominator == 0)
    {
        alreadyFizzBuzz = true;
        Write("Fizz");
    }

    if (index % buzzDenominator == 0)
    {
        alreadyFizzBuzz = true;
        Write("Buzz");
    }
    
    if (!alreadyFizzBuzz)
    {
        Write(index);
    }

    if (index != total)
    {
        Write(", ");
    }

    if (index % perLine == 0)
    {
        WriteLine();
    }
}