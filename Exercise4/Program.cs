Console.Write("Введите первое число: ");
string number1 = Console.ReadLine() ?? "";
int number1A = int.Parse(number1);
Console.Write("Введите второе число: ");
string number2 = Console.ReadLine() ?? "";
int number2A = int.Parse(number2);
Console.Write("Введите третье число: ");
string number3 = Console.ReadLine() ?? "";
int number3A = int.Parse(number3);

int max = number1A;

if(number2A > max)
{
    max = number2A;
}
if (number3A > max)
{
    max = number3A;
}
else
{
    max = number1A;
}
Console.WriteLine("max = " + max);