// See https://aka.ms/new-console-template for more information
using ConsoleApp3;
using System.IO;

//int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
//a = Arr.SortArray(a, 0, a.Length-1);
Arr arr = new Arr(7);
Arr.PrintArray(arr.arr);
Console.WriteLine(Arr.FindMaxValue(arr.arr));