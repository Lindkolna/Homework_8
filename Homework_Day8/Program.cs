// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter the first number:");
double number = double.Parse (Console.ReadLine());
Console.WriteLine("Enter the second number:");
double number2 = double.Parse (Console.ReadLine());
Console.WriteLine("Choose an operator:");
char act = char.Parse (Console.ReadLine());

switch (act)
{
    case '+':
        Console.WriteLine($"The result is: {number + number2}");
        break;
    case '-':
        Console.WriteLine($"The result is: {number - number2}");
        break;
    case '/':
        Console.WriteLine($"The result is: {number / number2}");
        break;
    case '*':
        Console.WriteLine($"The result is: {number * number2}");
        break;
    case '%':
        Console.WriteLine($"The result is: {number % number2}");
        break;
    case 'p':
        Console.WriteLine($"Both {number} {number2} numbers are:");
        break;
    case 'b':
        if (number > number2)
        {
            Console.WriteLine($"The biggest number is: {number}");
        }
        else if (number < number2)
        {
            Console.WriteLine($"The biggest number is: {number2}");
        }
        else if (number == number2)
        {
            Console.WriteLine("Both numbers are equal.");
        }
        break;
    case 's':
        if (number > number2)
        {
            Console.WriteLine($"The smallest number is: {number2}");
        }
        else if (number < number2)
        {
            Console.WriteLine($"The smallest number is: {number}");
        }
        else if (number == number2)
        {
            Console.WriteLine("Both numbers are equal.");
        }
        break;
}