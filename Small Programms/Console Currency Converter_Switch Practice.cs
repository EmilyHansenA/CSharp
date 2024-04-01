using System.Threading.Channels;

float rublesInWallet;
float dollarsInWallet;

float rubToUsd = 92.29f;
float usdToRub = 96.24f;

float exchangeCurrencyCount;

string desiredOperation;

Console.WriteLine("Welcome to the currency exchange.");

Console.Write("Enter your balance rubles: ");
rublesInWallet = Convert.ToSingle(Console.ReadLine());
Console.Write("Enter your balance dollars: ");
dollarsInWallet = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("Enter operation you want to commit: ");
Console.WriteLine("1 — Exchange rubles to dollars");
Console.WriteLine("2 — Exchange dollars to rubles");
Console.Write("Your choise: ");

desiredOperation = Console.ReadLine();

switch (desiredOperation)
{
    case "1":
        Console.WriteLine("1 — Exchange rubles to dollars");
        Console.Write("How much you want to exchange? ");
        exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
        if (rublesInWallet >= exchangeCurrencyCount)
        {
            rublesInWallet -= exchangeCurrencyCount;
            dollarsInWallet += exchangeCurrencyCount / rubToUsd;
        }
        else
        {
            Console.WriteLine("Not enough rubles");
        }
        break;

    case "2":
        Console.WriteLine("2 — Exchange dollars to rubles");
        Console.Write("How much you want to exchange? ");
        exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
        if (dollarsInWallet >= exchangeCurrencyCount)
        {
            dollarsInWallet -= exchangeCurrencyCount;
            rublesInWallet += exchangeCurrencyCount * usdToRub;
        }
        else
        {
            Console.WriteLine("Not enough dollars");
        }
        break;

    default:
        Console.WriteLine("Wrong operation");
        break;
}

Console.WriteLine($"Your balance\nrubles: {rublesInWallet}\ndollars {dollarsInWallet}");