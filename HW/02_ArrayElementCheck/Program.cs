// **Задача 50.** Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

using System;
using static System.Console;

Clear();
Write("Введите номер строки искомого элемента: ");		// нумерация строк и столбцов начинается с 0
int n = Convert.ToInt32(ReadLine());
Write("Введите номер столбца искомого элемента: ");
int m = Convert.ToInt32(ReadLine());
int[,] Array = GetRandomArray(3, 4, -10, 10);
PrintArray(Array);
WriteLine();
CheckElementByPosition(Array, n, m);

int[,] GetRandomArray (int row, int column, int minValue, int maxValue) {
	int[,] result = new int[row, column];
	for (int i = 0; i < row ; i ++) {
		for (int j = 0; j < column; j ++) {
			result[i, j] = new Random().Next(minValue, maxValue + 1);
		}
	}
	return result;
}

void CheckElementByPosition (int[,] array, int row, int column) {
	if (row < array.GetLength(0) && column < array.GetLength(1)) {
		WriteLine($"{row} {column} -> {array[row, column]}");
	} else	WriteLine($"{row} {column} -> такого числа нет в массиве");
}

void PrintArray (int[,] array) {
	for (int i = 0; i < array.GetLength(0); i ++) {
		for (int j = 0; j < array.GetLength(1); j ++) {
			Write($"{array[i, j]} ");
		}
		WriteLine();
	}
}
