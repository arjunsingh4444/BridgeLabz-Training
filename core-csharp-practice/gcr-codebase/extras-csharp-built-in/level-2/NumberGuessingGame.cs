using System;

class NumberGuessingGame
{
    static void Main()
    {
        int low = 1, high = 100;
        string feedback;
        int guess;

        Console.WriteLine("Think of a number between 1 and 100.");

        while (true)
        {
            // Generate guess
            guess = GenerateGuess(low, high);
            Console.WriteLine("Computer guesses: " + guess);

            // Get user feedback
            Console.Write("Is it High, Low or Correct? (h/l/c): ");
            feedback = Console.ReadLine();

            if (feedback == "c")
            {
                Console.WriteLine("Computer guessed correctly!");
                break;
            }
            else if (feedback == "h")
                high = guess - 1;
            else if (feedback == "l")
                low = guess + 1;
        }
    }

    // Function to generate guess
    static int GenerateGuess(int low, int high)
    {
        return (low + high) / 2;
    }
}
