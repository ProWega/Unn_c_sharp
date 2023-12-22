using Lab5_delegates;

Lab5_delegates.Task task = new Lab5_delegates.Task("Смотреть в потолок",
    "Требуется смотреть вверх и разглядывать текстуру потолка до тех пор, пока не надоест");
TaskCompletedNotification notification = new TaskCompletedNotification();

Lab5_delegates.Task task2 = new Lab5_delegates.Task("Слушать тишину",
    "Требуется прислушаться и концентрироваться на отсутствии звуков, пока не надоест");

TaskManager taskManager = new TaskManager();
taskManager.AddTask(task);
taskManager.AddTask(task2);
foreach (Lab5_delegates.Task task_ in taskManager.tasks)
{
    task_.OnComplete += notification.CompleteMessage;
}

task2.Complete();