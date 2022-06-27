// **Задача 46:** Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

using System;
using static System.Console;

Clear();

Write("Введите размер матрицы через пробел: ");
string[] sizeS = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
int rows = int.Parse(sizeS[0]);
int columns = int.Parse(sizeS[1]);
int[,] ar = GetRandomArray(rows, columns);
PrintArray(ar);

int[,] GetRandomArray (int row, int column) {
	int[,] result = new int[row, column];
	for (int i = 0; i < result.GetLength(0); i ++) {
		for (int j = 0; j < result.GetLength(1); j ++) {
			result[i,j] = new Random().Next(-10,10);
		}
	}
	return result;
}

void PrintArray(int[,] array) {
	for (int i = 0; i < array.GetLength(0); i ++) {
		for (int j = 0; j < array.GetLength(1); j ++) {
			Write($"{array[i, j]} ");
		}
		WriteLine();
	}
}
