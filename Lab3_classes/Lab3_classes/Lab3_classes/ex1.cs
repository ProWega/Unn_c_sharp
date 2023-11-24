// See https://aka.ms/new-console-template for more information

using Arrays;

Console.Write("Введите кол-во строк n: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(n); 

float[][] matrix = new float[n][];

for (int i = 0; i < n; i++)
{
    matrix[i] = Arrays.Arrays.FlotifyArray(Console.ReadLine().Split(' '));
}
//string b = Console.ReadLine();
string[] test = { "3,0", "3,0", "-7.8","wjekev6,8", "8", "5", "2124,21" };

float[] res = Arrays.Arrays.FlotifyArray(test);

float min;
Arrays.Arrays.FindMin(res, out min);
Console.WriteLine(min);
int row_number = 0;
foreach (float[] arr in matrix)
{
    row_number++;
    float min_value, max_value, sum_value;
    Arrays.Arrays.FindMin(arr, out min_value);
    Arrays.Arrays.FindMax(arr, out max_value);
    Arrays.Arrays.FindSum(arr, out sum_value);

    Console.WriteLine($"Строка {row_number}");
    Console.Write($"Min: {min_value} ");
    Console.Write($"Max: {max_value} ");
    Console.Write($"Sum: {sum_value}");
}


