using static System.Console;

// Generate random number between 1 and 100
Random rand = new();
int answer = rand.Next(1, 101);

WriteLine("Let's Play a guessing game!");

// Starts loop
while (true)
{
    int guess;
    Write("Enter a number between 1 and 100: ");

    // Try to parse the string into an int
    try
    {
        guess = int.Parse(ReadLine());
    }
    catch
    {
        WriteLine("Your guess needs to be a number.");
        continue;
    }

    // Guess is not a valid number
    if (guess > 100 || guess < 1)
    {
        WriteLine("Your guess needs to be between 1 and 100.");
        continue;
    }

    if (guess < answer)
    {
        WriteLine($"\nYour guess of {guess} is too low.");
    }
    else if (guess > answer)
    {
        WriteLine($"\nYour guess of {guess} is too high.");
    }
    // Winner!
    else
    {
        WriteLine();
        WriteLine($"You guessed correctly! The number is {answer}! Hit enter to close.");
        ReadLine();
        break;
    }
}