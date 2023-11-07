using System.Text;
using Lab2_Methods;

string path = @"C:\Users\Admin\source\repos\UpperLvl\Lab2_methods\Lab2_Methods\Lab2_Methods\input3.txt";
string textFromFile;
using (FileStream fstream = File.OpenRead(path))
{
    // выделяем массив для считывания данных из файла
    byte[] buffer = new byte[fstream.Length];
    // считываем данные
    await fstream.ReadAsync(buffer, 0, buffer.Length);
    // декодируем байты в строку
    textFromFile = Encoding.Default.GetString(buffer);
}

//Console.WriteLine(textFromFile);

Stack stack = new Stack();
stack.logText = false;
int i = 0;
foreach (char c in textFromFile)
{
    i++;
    if (c == '(')
    {
        stack.Push(1);
    }
    else if (c == ')')
    {
        if (stack.Pop() == 0)
        {
            Console.WriteLine($"Первая лишняя закрывающая скобка на позиции {i-1}");
            stack.Exit();
        }
    }
    //Console.WriteLine(c);
}
int size = stack.GetSize();
if (size == 0)
{
    Console.WriteLine("Нет лишних скобок");
}
else
{
    Console.WriteLine($"Лишних открывающих скобок: {size}");
}