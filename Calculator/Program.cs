Console.WriteLine("Hello, there!");

Console.WriteLine("Please input the first number:");
var input1 = Console.ReadLine();
int num1 = int.Parse(input1);

Console.WriteLine("Please input the second number:");
var input2 = Console.ReadLine();
int num2 = int.Parse(input2);

Console.WriteLine("What do you want to do with those numbers?");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[M]ultiply");
var choice = Console.ReadLine();

if (choice == "A" || choice == "a") {
    Console.WriteLine($"{num1} + {num2} = {num1+num2}");
}
else if (choice == "S" || choice == "s") {
    Console.WriteLine($"{num1} - {num2} = {num1-num2}");
}
else if (choice == "M" || choice == "m") {
    Console.WriteLine($"{num1} * {num2} = {num1*num2}");
}
else {
    Console.WriteLine("Invalid option!");

}

Console.WriteLine("Press any key to close. Thanks!");
Console.ReadKey();

