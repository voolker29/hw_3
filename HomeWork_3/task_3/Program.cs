using System;

Console.WriteLine("Введите первое число");
var a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
var b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите действие");

var action = Console.ReadLine();


switch (action)
{
	case "+":
        Console.WriteLine(a + b);
		break;
    case "-":
        Console.WriteLine(a -b);
        break;
    case "/":
        Console.WriteLine(a / b);
        break;
    case "%":
        Console.WriteLine(a % b);
        break;
    case "*":
        Console.WriteLine(a * b);
        break;
    default:
		break;
}

