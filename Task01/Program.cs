using System;
using static System.Console;

Clear();

int [] array = {1, 2, 3, 4, 5};
int max = array[0];
int min = array[0];
int sum = 0;
int count = 0;

foreach(var r in array) {
	max = max < r ? r : max;
	min = min > r ? r : min;
	sum += r;
	count += r % 2 == 0 ? 1 : 0;
}
WriteLine($"{min} {max} {sum} {count}");
WriteLine(String.Join(",", GetArrayFrom("1 2 3")));

int[] GetArrayFrom (string strAr) {
	string[] arS = strAr.Split(' ', StringSplitOptions.RemoveEmptyEntries);
	int[] result = new int[arS.Length];
	int i = 0;
	foreach (var item in arS) {
		result[i] = int.Parse(item);
		i ++;
	}
	return result;
}
