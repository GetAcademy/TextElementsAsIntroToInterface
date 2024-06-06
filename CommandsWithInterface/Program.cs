using CommandsWithInterface;
using Task = CommandsWithInterface.Task;

var todoApp = new TodoApp();
while (true)
{
    Console.Clear();
    todoApp.Show();
    Console.WriteLine(@"Hva vil du gjøre? 
1 = legge til ny oppgave
2 = markere oppgave som gjort");
    var cmdNo = Console.ReadLine();
    if (cmdNo == "1")
    {
        Console.Write("Hva er oppgaven? ");
        var taskText = Console.ReadLine();
        var task = new Task(taskText);
        todoApp.AddTask(task);
    }
    else if (cmdNo == "2")
    {
        Console.WriteLine("Skriv inn rad nr. til oppgaven som er gjort: ");
        var taskNo = Convert.ToInt32(Console.ReadLine());
        todoApp.MarkDone(taskNo);
    }
}