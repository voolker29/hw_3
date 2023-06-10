Console.WriteLine("Введите месяц числом");
var a = Convert.ToInt32(Console.ReadLine());

if (a == 1 || a ==12 || a ==2)
{
    Console.WriteLine("Зима");

}
else if (a == 3 || a == 4 || a == 5)
{
    Console.WriteLine("Весна");
}
else if (a == 6 || a == 7 || a == 8)
{
    Console.WriteLine("Лето");
}
else if (a == 9 || a == 10 || a == 11)
{
    Console.WriteLine("Осень");

}