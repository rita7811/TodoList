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

if (EqualsCaseInsensitive(choice, "A")) {
    var sum = num1 + num2;
    PrintResult(num1, num2, sum, "+");
}
else if (EqualsCaseInsensitive(choice, "S")) {
    var difference = num1 - num2;
    PrintResult(num1, num2, difference, "-");
}
else if (EqualsCaseInsensitive(choice, "M")) {
    var multiplied = num1 * num2;
    PrintResult(num1, num2, multiplied, "*");
}
else {
    Console.WriteLine("Invalid option!");

}

bool EqualsCaseInsensitive (string left, string right) {
    return left.ToUpper() == right.ToUpper();
}

void PrintResult(int number1, int number2, int result, string @operator){
    Console.WriteLine($"{number1} {@operator} {number2} = {result}");
}

Console.WriteLine("Press any key to close. Thanks!");
Console.ReadKey();
