// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
Action<string> turnOnColor = (x) => Console.WriteLine(x);

turnOnColor.Invoke("RED");
Thread.Sleep(20*1000);
turnOnColor.Invoke("YELLOW");
Thread.Sleep(5*1000);
turnOnColor.Invoke("GREEN");
Thread.Sleep(15*1000);
Console.WriteLine("World has been destroyed :(");
