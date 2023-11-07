using Lab2_Methods;


Deque<int> deque = new Deque<int>();
deque.AddLast(5);
deque.AddFirst(1);
deque.AddFirst(2);
deque.AddFirst(3);
deque.AddLast(4);
deque.AddLast(5);
//Console.WriteLine(deque.tail.Data);
deque.Print();
deque.Find(4);
deque.Remove(5);
deque.Print();
deque.Find(4);

//Console.WriteLine(deque.size);