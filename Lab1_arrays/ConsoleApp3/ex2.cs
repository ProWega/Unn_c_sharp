// See https://aka.ms/new-console-template for more information
Console.WriteLine(5 / 2);
int[] q = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
PrintArray(q);
ReverseParts(q);
PrintArray(q);

void ReverseParts(int[] q)
{
    if (q.Length % 2 == 1)
    {
        for (int i = 0; i < q.Length / 2; i++)
        {
            Swap(i, q.Length / 2 + i, q);
        }
        for (int i = 0; i < q.Length / 2; i++)
        {
            Swap(q.Length - 1, q.Length / 2 + i, q);
        }
    }
    else
    {
        Console.WriteLine(q.Length);
        for (int i = 0; i < q.Length / 2; i++)
        {
            Swap(i, q.Length / 2 + i, q);
        }
    }

}

void Swap(int a, int b, int[] q)
{
    //Console.WriteLine($"Swap({a}, {b})");
    int temp = q[a];
    q[a] = q[b];
    q[b] = temp;
}
void PrintArray(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        if (i == 0)
        {
            Console.Write($"Массив: [{a[i]}, ");
        }
        else if (i == a.Length - 1)
        {
            Console.Write($"{a[i]}]\n");
        }
        else
        {
            Console.Write($"{a[i]}, ");
        }

    }
}