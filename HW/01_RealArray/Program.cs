// **Задача 47**. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
using System;
using static System.Console;

Clear();
WriteLine("Задайте двумерный массив размером m x n");
Write("Введите m: ");
int m = Convert.ToInt32(ReadLine());
Write("Введите n: ");
int n = Convert.ToInt32(ReadLine());
PrintRealArray(GetRandomRealArray(m, n, -10, 10));


double[,] GetRandomRealArray (int row, int column, int minValue, int maxValue) {
	double[,] result = new double[row, column];
	for (int i = 0; i < row ; i ++) {
		for (int j = 0; j < column; j ++) {
			result[i, j] = new Random().Next(minValue, maxValue) + new Random().NextDouble();
		}
	}
	return result;
}

void PrintRealArray (double[,] array) {
	for (int i = 0; i < array.GetLength(0); i ++) {
		for (int j = 0; j < array.GetLength(1); j ++) {
			Write($"{array[i, j]:f1} ");	// Вывод делаем с округлением до одной десятой
		}
		WriteLine();
	}
}
