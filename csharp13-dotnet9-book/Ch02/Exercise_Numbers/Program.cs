using System.Runtime.InteropServices;

const int typeColumnWidth = 10;
const int bytesColumnWidth = 20;
const int minColumnWidth = 42;
const int maxColumnWidth = 42;
var horizontalBorder = new string('-', typeColumnWidth + bytesColumnWidth + minColumnWidth + maxColumnWidth);

Console.WriteLine(horizontalBorder);

Console.WriteLine("Type".PadRight(typeColumnWidth) + "Byte(s) of Memory".PadRight(bytesColumnWidth) + "Min".PadRight(minColumnWidth) + "Max".PadRight(maxColumnWidth));


Console.WriteLine("sbyte".PadRight(typeColumnWidth) + sizeof(sbyte).ToString().PadRight(bytesColumnWidth) + sbyte.MinValue.ToString().PadLeft(minColumnWidth) + sbyte.MaxValue.ToString().PadLeft(maxColumnWidth));
Console.WriteLine("byte".PadRight(typeColumnWidth) + sizeof(byte).ToString().PadRight(bytesColumnWidth) + byte.MinValue.ToString().PadLeft(minColumnWidth) + byte.MaxValue.ToString().PadLeft(maxColumnWidth));
Console.WriteLine("short".PadRight(typeColumnWidth) + sizeof(short).ToString().PadRight(bytesColumnWidth) + short.MinValue.ToString().PadLeft(minColumnWidth) + short.MaxValue.ToString().PadLeft(maxColumnWidth));
Console.WriteLine("ushort".PadRight(typeColumnWidth) + sizeof(ushort).ToString().PadRight(bytesColumnWidth) + ushort.MinValue.ToString().PadLeft(minColumnWidth) + ushort.MaxValue.ToString().PadLeft(maxColumnWidth));
Console.WriteLine("int".PadRight(typeColumnWidth) + sizeof(int).ToString().PadRight(bytesColumnWidth) + int.MinValue.ToString().PadLeft(minColumnWidth) + int.MaxValue.ToString().PadLeft(maxColumnWidth));
Console.WriteLine("uint".PadRight(typeColumnWidth) + sizeof(uint).ToString().PadRight(bytesColumnWidth) + uint.MinValue.ToString().PadLeft(minColumnWidth) + uint.MaxValue.ToString().PadLeft(maxColumnWidth));
Console.WriteLine("long".PadRight(typeColumnWidth) + sizeof(long).ToString().PadRight(bytesColumnWidth) + long.MinValue.ToString().PadLeft(minColumnWidth) + long.MaxValue.ToString().PadLeft(maxColumnWidth));
Console.WriteLine("ulong".PadRight(typeColumnWidth) + sizeof(ulong).ToString().PadRight(bytesColumnWidth) + ulong.MinValue.ToString().PadLeft(minColumnWidth) + ulong.MaxValue.ToString().PadLeft(maxColumnWidth));
Console.WriteLine("Int128".PadRight(typeColumnWidth) + Marshal.SizeOf<Int128>().ToString().PadRight(bytesColumnWidth) + Int128.MinValue.ToString().PadLeft(minColumnWidth) + Int128.MaxValue.ToString().PadLeft(maxColumnWidth));
Console.WriteLine("UInt128".PadRight(typeColumnWidth) + Marshal.SizeOf<UInt128>().ToString().PadRight(bytesColumnWidth) + UInt128.MinValue.ToString().PadLeft(minColumnWidth) + UInt128.MaxValue.ToString().PadLeft(maxColumnWidth));
Console.WriteLine("Half".PadRight(typeColumnWidth) + Marshal.SizeOf<Half>().ToString().PadRight(bytesColumnWidth) + Half.MinValue.ToString().PadLeft(minColumnWidth) + Half.MaxValue.ToString().PadLeft(maxColumnWidth));
Console.WriteLine("float".PadRight(typeColumnWidth) + sizeof(float).ToString().PadRight(bytesColumnWidth) + float.MinValue.ToString().PadLeft(minColumnWidth) + Half.MaxValue.ToString().PadLeft(maxColumnWidth));
Console.WriteLine("double".PadRight(typeColumnWidth) + sizeof(double).ToString().PadRight(bytesColumnWidth) + double.MinValue.ToString().PadLeft(minColumnWidth) + double.MaxValue.ToString().PadLeft(maxColumnWidth));
Console.WriteLine("decimal".PadRight(typeColumnWidth) + sizeof(decimal).ToString().PadRight(bytesColumnWidth) + decimal.MinValue.ToString().PadLeft(minColumnWidth) + decimal.MaxValue.ToString().PadLeft(maxColumnWidth));
