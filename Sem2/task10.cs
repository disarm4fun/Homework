Console.Write(" Введите трёхзначное число: ");
int num1 = int.Parse(Console.ReadLine()!);

// ловим попадание в диапазон
if ((num1 >= 100) && (num1 < 1000))
{   //считаеми сообщаем
    int result = (num1 % 100) / 10;
    Console.Write(" Вторая цифра: " + num1);
}
else
{
    Console.Write(" не трёхзначное число ");
}