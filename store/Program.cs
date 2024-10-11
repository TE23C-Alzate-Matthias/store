int money = 100;
int numBuy;
int finalCost;
int price;

bool success;

string buy;
string num;
string[] acceptable = [ "1", "2", "3", "4"];

while (money > 0)
{
    Console.WriteLine($"Du har {money} kronor kvar\n");

    // vad man kan köpa

    Console.WriteLine("Vad vill du köpa?");
    Console.WriteLine("1. Bronzestaty (10kr)");
    Console.WriteLine("2. Silvermedalj (20kr)");
    Console.WriteLine("3. Guldkrona (30kr)");
    Console.WriteLine("4. Avbryt programmet");

    buy = Console.ReadLine();

    while (!acceptable.Contains(buy))
    {
        Console.WriteLine("Okänt svar, försök igen.");
        buy = Console.ReadLine();
    }

    // Priset för varje grej

    price = 0;

    if (buy == "1")
    {
        price = 10; // sätter priset
    }
    else if (buy == "2")
    {
        price = 20;
    }
    else if (buy == "3")
    {
        price = 30;
    }
    else if(buy == "4")
    {
        Environment.Exit(0); // Avslutar programmet direkt
    }

    // Antal man vill köpa

    Console.WriteLine("Hur många vill du köpa?");
    numBuy = 0;

    while (numBuy == 0)
    {
        num = Console.ReadLine();
        success = int.TryParse(num, out numBuy); // checkar om num bara har siffor i sig och om den ahr det sätter den i numBuy
        if (success == false)
        {
            Console.WriteLine("Du får bara skriva in siffror");
        }
    }

    finalCost = price * numBuy;

    if (finalCost <= money)
    {
        Console.WriteLine("Det går bra att köpa\n");
        money -= finalCost;
    }
    else
    {
        Console.WriteLine("Du har inte råd\n");
    }

}

Console.WriteLine("Nu har du inga pengar kvar!");
Console.WriteLine("Tryck på valfri knapp för att stänga programet");
Console.ReadKey();