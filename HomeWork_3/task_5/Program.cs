Console.WriteLine("Введите температуру");
var a = Convert.ToInt32(Console.ReadLine());



switch (a)
{
    case < 0:
        Console.WriteLine("очень холодно");
        break;
    case <=10 and > 0:
        Console.WriteLine("холодно");
        break;
    case >10 and < 20:
        Console.WriteLine("нормально");
        break;
    case >= 20 and < 30:
        Console.WriteLine("тепло");
        break;
    case >= 30:
        Console.WriteLine("жарко");
        break;
   
    default:
        break;
}