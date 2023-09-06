Console.WriteLine("Hello, there!");

List<string> todos = new List<string>();
bool toExit = false;

while (!toExit)
{
    Console.WriteLine();
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[S]ee all TODOs");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");

    var userChoice = Console.ReadLine();

    switch (userChoice)
    {
        case "S":
        case "s":
            SeeAllTodos();
            break;
        case "A":
        case "a":
            AddTodo();
            break;
        case "R":
        case "r":
            RemoveTodo();
            break;
        case "E":
        case "e":
            toExit = true;
            Console.WriteLine("Press any key to close. Thanks!");
            Console.ReadKey();
            break;
        default:
            Console.WriteLine("Incorrect input");
            break;
    }
}


void SeeAllTodos()
{
    if (todos.Count == 0)
    {
        ShowNoTodosMessage();
        return;
    }
    for (int i = 0; i < todos.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {todos[i]}");

    }
}


void AddTodo()
{
    string description;
    do
    {
        Console.WriteLine("Please enter the TODO description:");
        description = Console.ReadLine();
    }
    while (!IsDescriptionValid(description));

    todos.Add(description);
    Console.WriteLine($"TODO successfully added: {description}");
}

bool IsDescriptionValid(string description) {

    if (description == "")
    {
        Console.WriteLine("The description cannot be empty.");
        return false;
    }
    if (todos.Contains(description))
    {
        Console.WriteLine("Sorry, the description must be unique.");
        return false;
    }
    return true;
}


void RemoveTodo()
{
    if (todos.Count == 0)
    {
        ShowNoTodosMessage();
        return;

    }

    int index;
    do
    {
        Console.WriteLine("Please select the index of the TODO you want to remove:");
        SeeAllTodos();
    }
    while (!TryReadIndex(out index));

    RemoveTodoAtIndex(index - 1);
}

void RemoveTodoAtIndex(int index)
{
    var deletedTodo = todos[index];
    todos.RemoveAt(index);
    Console.WriteLine($"TODO removed: {deletedTodo}");
}

bool TryReadIndex(out int index)
{
    var removeTodo = Console.ReadLine();

    if (removeTodo == "")
    {
        Console.WriteLine("Sorry, selected index cannot be empty.");
        index = 0;
        return false;
    }
    if (int.TryParse(removeTodo, out index) && index <= todos.Count && index > 0)
    {
        return true;
    }
    Console.WriteLine("Sorry, the given index is not valid.");
    return false;   
}


static void ShowNoTodosMessage()
{
    Console.WriteLine("Sorry, no TODOs have been added yet.");
}
