using Lab2_Methods;
using System.Text;

Queue queue = new Queue();
//queue.Push(1);
//queue.Front();
//queue.Push(3);
//queue.Pop();
//queue.Pop();
//queue.Pop();
//queue.Pop();
//queue.Push(234);
//queue.Front();

string path = @"C:\Users\Admin\source\repos\UpperLvl\Lab2_methods\Lab2_Methods\Lab2_Methods\input2.txt";
using (FileStream fstream = File.OpenRead(path))
{
    // выделяем массив для считывания данных из файла
    byte[] buffer = new byte[fstream.Length];
    // считываем данные
    await fstream.ReadAsync(buffer, 0, buffer.Length);
    // декодируем байты в строку
    string textFromFile = Encoding.Default.GetString(buffer);
    //Console.WriteLine($"Текст из файла: {textFromFile}");
    string[] commands = textFromFile.Split("\n");
    foreach (string command in commands)
    {
        ExecuteCommand(queue, command);
    }
}

void ExecuteCommand(Queue queue, string command)
{
    if (command.Contains("push"))
    {
        //Console.WriteLine("push");
        int value = Convert.ToInt32(command.Split(" ")[1]);
        queue.Push(value);
    }
    else if (command.Contains("pop"))
    {
        queue.Pop();
    }
    else if (command.Contains("front"))
    {
        queue.Front();
    }
    else if (command.Contains("clear"))
    {
        queue.Clear();
    }
    else if (command.Contains("size"))
    {
        queue.Size();
    }
    else if (command.Contains("exit"))
    {
        queue.Exit();
    }
    else
    {
        throw new Exception("Unknown command");
    }
}