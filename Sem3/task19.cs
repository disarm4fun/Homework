Console.WriteLine("Введите пятизначное чилсо");
int number = Math.Abs(int.Parse(Console.ReadLine()!));
int[] array = new int[5];
for (int i = 0; i <= 4; i++)
{
    array[i] = number % 10;
    number = number / 10;
}
if (array[0] == array[4] && array[1] == array[3])
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}