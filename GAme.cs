using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Number Guessing Game! :)");
        
        // Generate a random number between 1 and 100.
        Random random = new Random();
        int secretNumber = random.Next(1, 101);

        int attempts = 0;
        bool hasGuessedCorrectly = false;

        while (!hasGuessedCorrectly)
        {
            Console.Write("Enter your guess (1-100): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int guess))
            {
                attempts++;

                if (guess < secretNumber)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else if (guess > secretNumber)
                {
                    Console.WriteLine("Too high! Try again.");
                }
                else
                {
                    Console.WriteLine($"Congratulations! You guessed the number {secretNumber} in {attempts} attempts.");
                    hasGuessedCorrectly = true;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        Console.WriteLine("Thanks for playing!");
    }
}
