int number;
int lower, higher;
int triesCount = 5;

Random random = new Random();

number = random.Next(0, 101);
lower = random.Next(number - 10, number);
higher = random.Next(number + 1, number + 10);

Console.WriteLine($"Число от 0 до 100, больше чем {lower}, " +
    $"меньше чем {higher}");
Console.WriteLine($"Отгадайте число. У вас {triesCount} попыток.");

while (triesCount-- > 0)
{
    Console.Write($"Догадка: ");

    if (Convert.ToInt32(Console.ReadLine()) == number)
    {
        Console.WriteLine($"Вы выиграли. Число {number}");
        break;
    }
    else if (triesCount != 0)
    {
        Console.WriteLine("Нет. Осталось попыток " + triesCount);
    }
    else
    {
        Console.WriteLine("Вы проиграли. Загаданное число: " + number);
    }
}