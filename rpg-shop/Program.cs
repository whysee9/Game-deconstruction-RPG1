Console.WriteLine("Greetings Adventurer! What is your name?");

string playerName = Console.ReadLine();

Console.WriteLine($"Hi {playerName}, I SELL SWORDS!");
Console.WriteLine($"How much GOLD do you have {playerName}?");
string totalGold = Console.ReadLine();
int numGOLD = int.Parse(totalGold);

Console.WriteLine("Buy a bronze sword for 15 GOLD?");
string purchaseSucessful = Console.ReadLine();
if (purchaseSucessful == "yes")
{
    if (numGOLD >= 15) 
    {
        Console.WriteLine("Bronze Sword accquired!");
        int remainingGold = numGOLD - 15;
        Console.WriteLine($"Gold left: {remainingGold}.");
    }
    else if (numGOLD < 15)
    {
        Console.WriteLine($"You do not have enough GOLD {playerName}. Total GOLD: {numGOLD}.");
    }
    else
    {
        Console.WriteLine("Try again...");
    }
}
else
{
    Console.Write($"Goodbye then, {playerName}.");
}