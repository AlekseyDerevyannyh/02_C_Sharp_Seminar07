using System;
using static System.Console;
using System.Linq;

Clear();

Write("Введите массив через пробел: ");

int[] array = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
.Select(x => int.Parse(x)).Where(x => x % 2 == 0).ToArray();
WriteLine(String.Join(", ", array));
