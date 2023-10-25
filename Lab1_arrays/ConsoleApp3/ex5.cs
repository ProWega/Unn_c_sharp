using ConsoleApp3;
int deep = 1000;
int[] a1 = new Arr(deep*deep).arr;
int[] a2 = new Arr(deep*deep).arr;
int[] result = new int[deep*deep];
//i-строка j-столбец
for (int i = 0; i < deep; i++)
{
    for (int j = 0; j < deep; j++)
    {
        result[i*deep+j] = Find_i_j_mult(i,j, a1, a2);
    }
}
Console.WriteLine("Готово");

int Find_i_j_mult(int i, int j, int[] a1, int[] a2)
{
    int sum = 0;
    for (int k = 0; k < deep; k++)
    {
        sum += Find_i_j(i, k, a1) * Find_i_j(k, i, a2);
    }
    return sum;
}
int Find_i_j(int i, int j, int[] a)
{
    return a[i*deep + j];
}

