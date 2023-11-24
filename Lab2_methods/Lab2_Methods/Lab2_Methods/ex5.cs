int[] arr = { 2, 3, 8, 5, 12, 453, 23, 2 };
Check(arr);


void Check(int[] arr)
{
    int prev = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (Math.Abs(arr[i] - prev) == 1)
        {
            Console.WriteLine("YES");
            System.Environment.Exit(0);

        }
        prev = arr[i];
    }
    Console.WriteLine("NO");
}