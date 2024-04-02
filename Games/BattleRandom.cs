Random rand = new Random();

float health1 = rand.Next(90, 110);
int damage1 = rand.Next(10, 40);
int armor1 = rand.Next(45, 100);

float health2 = rand.Next(80, 120);
int damage2 = rand.Next(5, 40);
int armor2 = rand.Next(65, 100);

Console.WriteLine($"Воин 1 — Здоровье: {health1}, Урон: {damage1}, Броня: {armor1}");
Console.WriteLine($"Воин 2 — Здоровье: {health2}, Урон: {damage2}, Броня: {armor2}");

while (health1 > 0 && health2 > 0)
{
    health1 -= Convert.ToSingle(rand.Next(0, damage2 + 1)) / 100 * armor1;
    health2 -= Convert.ToSingle(rand.Next(0, damage1 + 1)) / 100 * armor2;

    Console.WriteLine($"Здоровье воина 1: {health1}");
    Console.WriteLine($"Здоровье воина 2: {health2}");

    if (health1 <= 0 && health2 <= 0)
    {
        Console.WriteLine("Ничья. Оба воина погибли");
    }
    else if (health1 <= 0)
    {
        Console.WriteLine("Воин 1 погиб");
    }
    else if (health2 <= 0)
    {
        Console.WriteLine("Воин 2 погиб");
    }
}