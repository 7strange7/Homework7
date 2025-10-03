using System.Diagnostics;
// The Magic Cannon
Debug.Assert(FrequencyType(3) == "Fire");
Debug.Assert(FrequencyType(20) == "Electric");

Console.Clear();

for (int crankNum = 1; crankNum <= 100; crankNum++)
{

    Console.Write($"{crankNum}: ");
    Console.WriteLine(FrequencyType(crankNum));

}

string FrequencyType(double element)
{
    if (element % 3 == 0) return "Fire";

    else if (element % 5 == 0) return "Electric";

    return "Normal";
}

Console.ReadLine();

Console.Clear();

// Pilot and Hunter Guessing Game
int targetNum;
int guessNum;
Console.WriteLine("Welcome to the Guessing game");
Console.Write("Pilot please enter a target number: ");

targetNum = int.Parse(Console.ReadLine());

do
{

Console.WriteLine("Hunter please enter number to guess: ");

guessNum = int.Parse(Console.ReadLine());

GuessingGame(targetNum, guessNum);

} while (targetNum != guessNum);

void GuessingGame(int target, int guess)
{
    if (target == guess)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("You guessed the number!");
    }
    else if (target > guess)
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("Too high.");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Too low.");
    }

    Console.ForegroundColor = ConsoleColor.White;   
}