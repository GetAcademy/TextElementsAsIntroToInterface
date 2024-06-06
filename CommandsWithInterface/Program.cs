using CommandsWithInterface;

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
    }
    else if (cmdNo == "2")
    {
    }
}