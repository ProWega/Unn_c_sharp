// See https://aka.ms/new-console-template for more information

// Задание и печать основного массива
double[] a = { 1, 1, 5 };
PrintArray(a);

#region Программа

#region Ввод пользовательских данных
Console.Write("Сколько элементов добавить: ");
int countOfNumbersToAdd = Convert.ToInt32(Console.ReadLine());
int k = int.MaxValue;
while (k > a.Length || k < 0)
{
    Console.Write("С какого индекса к нужно начать: ");
    k = Convert.ToInt32(Console.ReadLine());
}
#endregion

#region Вычисления
// Сохранение элементов после к
double[] tail = new double[a.Length - k];
for (int i = 0; i < tail.Length; i++)
{
    tail[i] = a[i + k];
}

// Добавление новых чисел, начиная с индекса к
for (int i = 0; i < countOfNumbersToAdd; i++)
{
    Console.Write($"Введите {i} число: ");

    double number = Convert.ToDouble(Console.ReadLine());
    a = AddDoubleToArray(a, number, k + i);
}

//Добавление хвоста
a = AddTailToArray(a, tail);
PrintArray(a);
#endregion

#endregion

#region Реализация функций
// Добавить элемент в позицию с индексом position
double[] AddDoubleToArray(double[] a, double number, int position)
{
    if (position > a.Length - 1)
    {
        double[] arr = new double[a.Length + 1];
        for (int i = 0; i < a.Length; i++)
        {
            arr[i] = a[i];
        }
        arr[a.Length] = number;
        return arr;
    }
    else
    {
        a[position] = number;
        return a;
    }
}
// Добавить хвост к массиву
double[] AddTailToArray(double[] a, double[] tail)
{
    double[] arr = new double[a.Length + tail.Length];
    for (int i = 0; i < a.Length; i++)
    {
        arr[i] = a[i];
    }
    for (int i = 0; i < tail.Length; i++)
    {
        arr[a.Length + i] = tail[i];
    }
    return arr;
}
//Напечатать массив
void PrintArray(double[] a)
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
#endregion