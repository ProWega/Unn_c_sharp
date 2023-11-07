// See https://aka.ms/new-console-template for more information
using Lab2_Methods;
using System.Text;

Stack stack = new Stack();
//stack.Push(3);
//stack.Back();
//stack.Push(4);
//stack.Back();
//stack.Size();
//stack.Pop();
//stack.Back();
//stack.Pop();
//stack.Back();
//stack.Size();

string path = @"C:\Users\Admin\source\repos\UpperLvl\Lab2_methods\Lab2_Methods\Lab2_Methods\input.txt";
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
        ExecuteCommand(stack ,command);
    }
}

void ExecuteCommand(Stack stack, string command)
{
    if (command.Contains("push")){
        //Console.WriteLine("push");
        int value = Convert.ToInt32(command.Split(" ")[1]);
        stack.Push(value);
    }
    else if (command.Contains("pop"))
    {
        stack.Pop();
    }
    else if (command.Contains("back"))
    {
        stack.Back();
    }
    else if (command.Contains("clear"))
    {
        stack.Clear();
    }
    else if (command.Contains("size"))
    {
        stack.Size();
    }
    else if (command.Contains("exit"))
    {
        stack.Exit();
    }
    else
    {
        throw new Exception("Unknown command");
    }
}
