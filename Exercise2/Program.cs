Console.Write("Введите первое число: ");
string number1 = Console.ReadLine() ?? "";
int number1A = int.Parse(number1);
Console.Write("Введите второе число: ");
string number2 = Console.ReadLine() ?? "";
int number2A = int.Parse(number2);
if(number1A > number2A)
{
    int max = number1A;
    Console.WriteLine("a=" + number1A + " b=" + number2A + " -> max = " + max);
}
else
{
    int max = number2A;
    Console.WriteLine("a=" + number1A + " b=" + number2A + " -> max = " + max);
}