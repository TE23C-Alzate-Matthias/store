int money = 100;

string buy;
string[] acceptable = [ "1", "2", "3"];

while (money > 0)
{
    Console.WriteLine($"Du har {money} kronor kvar\n");

    // vad man kan köpa

    Console.WriteLine("Vad vill du köpa?");
    Console.WriteLine("1. Bronzemedalj (10kr)");
    Console.WriteLine("2. Silvermedalj (20kr)");
    Console.WriteLine("3. Guldmedalj (30kr)");

    buy = Console.ReadLine();

    while (!acceptable.Contains(buy))
    {
        Console.WriteLine("Okänt svar, försök igen.");
        buy = Console.ReadLine();
    }

    // priset för varje grej

    int price = 0;

    if (buy == "1")
    {
        price = 10;
    }
    else if (buy == "2")
    {
        price = 20;
    }
    else if (buy == "3")
    {
        price = 30;
    }

}

