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
        Console.WriteLine("Sorry, your TODOs is empty");

    }
    else
    {
        for (int i = 0; i < todos.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {todos[i]}");

        }
    }
}


void AddTodo()
{
    bool isUserAddChoice = false;
    while (!isUserAddChoice)
    {
        Console.WriteLine("Please enter the TODO description:");
        var addTodo = Console.ReadLine();

        if (addTodo == "")
        {
            Console.WriteLine("The description cannot be empty.");
        }
        else if (todos.Contains(addTodo))
        {
            Console.WriteLine("Sorry, the description must be unique.");
        }
        else
        {
            isUserAddChoice = true;
            todos.Add(addTodo);
            Console.WriteLine($"TODO successfully added: {addTodo}");
        }
    }
}


void RemoveTodo()
{
    if (todos.Count == 0)
    {
        Console.WriteLine("Sorry, no TODOs have been added yet.");
        return;

    }

    bool isIndexValid = false;
    while (!isIndexValid)
    {
        Console.WriteLine("Please select the index of the TODO you want to remove:");
        SeeAllTodos();
        var removeTodo = Console.ReadLine();

        if (removeTodo == "")
        {
            Console.WriteLine("Sorry, selected index cannot be empty.");
            continue;
        }

        if (int.TryParse(removeTodo, out int index) && index <= todos.Count && index > 0)
        {
            var indexOfTodo = index - 1;
            var deletedTodo = todos[indexOfTodo];
            todos.RemoveAt(indexOfTodo);
            isIndexValid = true;
            Console.WriteLine($"TODO removed: {deletedTodo}");
        }
        else
        {
            Console.WriteLine("Sorry, the given index is not valid.");
        }
    }
}
