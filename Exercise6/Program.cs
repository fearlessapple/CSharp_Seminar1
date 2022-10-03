Console.Write("Введите число: ");
string number1 = Console.ReadLine() ?? "";
int number1A = int.Parse(number1);

if(number1A % 2 == 0)
{
    Console.WriteLine("Число чётное");
}
else
{
    Console.WriteLine("Число нечётное");
}