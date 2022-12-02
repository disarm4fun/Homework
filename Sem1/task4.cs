Console.WriteLine("Введите первое число");
string num1 = Console.ReadLine()!;
int num1int = int.Parse(num1);

Console.WriteLine("Введите второе число");
string num2 = Console.ReadLine()!;
int num2int = int.Parse(num2);

Console.WriteLine("Введите первое число");
string num1 = Console.ReadLine()!;
int num1int = int.Parse(num1);

for (int i = 1; i <= num1int; i++)
{
   if (i % 2 == 0)
   {
    Console.WriteLine(i + "число чётное");
   }
}