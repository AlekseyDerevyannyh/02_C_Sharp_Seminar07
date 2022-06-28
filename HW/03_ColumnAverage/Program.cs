// **Задача 52.** Задайте двумерный массив из целых чисел. Найдите среднее арифметическое
// элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
using System;
using static System.Console;
using System.Linq;

Clear();
int[,] Array = GetRandomArray(3, 4, -10, 10);
PrintArray(Array);
WriteLine();
// Делаем вывод с округлением результатов до одной десятой
Write($"Среднее арифметическое каждого столбца: {String.Join("; ", ColumnAverage(Array).Select(q => Math.Round(q, 1)).ToArray())}.");

int[,] GetRandomArray (int row, int column, int minValue, int maxValue) {
	int[,] result = new int[row, column];
	for (int i = 0; i < row ; i ++) {
		for (int j = 0; j < column; j ++) {
			result[i, j] = new Random().Next(minValue, maxValue + 1);
		}
	}
	return result;
}

void PrintArray (int[,] array) {
	for (int i = 0; i < array.GetLength(0); i ++) {
		for (int j = 0; j < array.GetLength(1); j ++) {
			Write($"{array[i, j]} ");
		}
		WriteLine();
	}
}

double[] ColumnAverage (int[,] array) {
	double[] result = new double[array.GetLength(1)];
	for (int j = 0; j < array.GetLength(1); j ++) {
		for (int i = 0; i < array.GetLength(0); i ++) {
			result[j] += array[i, j];
		}
		result[j] /= array.GetLength(0);
	}
	return result;
}
