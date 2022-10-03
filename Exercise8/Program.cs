Console.Write("Введите число: ");
string number1 = Console.ReadLine() ?? "";
int number1A = int.Parse(number1);

int count = 2;

while(count <= number1A)
{
    Console.WriteLine(count);
    count = count + 2;
}