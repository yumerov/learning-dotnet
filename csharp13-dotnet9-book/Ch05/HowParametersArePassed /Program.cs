using static System.Console;
using Fruit = (string Name, int Number); // Alias

WriteLine("Controlling how parameters are passed:");

void PassingParameters(int w, in int x, ref int y, out int z)
{
    z = 100;
    w++;
    y++;
    z++;
    WriteLine($"In the method: w={w}, x={x}, y={y}, z={z}");
}

int a = 10;
int b = 20;
int c = 30;
int d = 40;
WriteLine($"Before: a={a}, b={b}, c={c}, d={d}");
PassingParameters(a, b, ref c, out d);
WriteLine($"After: a={a}, b={b}, c={c}, d={d}");

WriteLine("");
WriteLine("Passing a variable number of parameters:");
void ParamsParameters(string text, params int[] numbers)
{
    int total = 0;
    foreach(int number in numbers)
    {
        total += number;
    }
    WriteLine($"{text}: {total}");
}
ParamsParameters("Sum using commas", 3, 6, 1, 2);
ParamsParameters("Sum using collection expression", [3, 6, 1, 2]);
ParamsParameters("Sum using explicit array", new int[] { 3, 6, 1, 2 });
ParamsParameters("Sum (empty)");

WriteLine();
WriteLine("Combining multiple returned values using tuples:");

static Fruit GetNamedFruit() => (Name: "Apples", Number: 5);
Fruit fruitNamed = GetNamedFruit();
WriteLine($"There are {fruitNamed.Number} {fruitNamed.Name}.");

static int DoubleIt(int number)
{
    static int Add(int a, int b) => a + b;

    return Add(number, number);
}